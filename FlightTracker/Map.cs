using MapWinGIS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point = MapWinGIS.Point;
using FlightTrackerClassLib;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace FlightTracker
{
    public partial class Map : Form
    {
        //Generating object of needed repository for CRUD operations on the DB and gathering info from API.
        private PositionRepository pR = new PositionRepository();
        //Countructor for Map form.
        public Map()
        {
            InitializeComponent();
        }
        //Triggers on form load and calls needed functions.
        private void Map_Load(object sender, EventArgs e)
        {   
            RotateImages();
            CreatePointShapefile();
        }
        //Get's the image in normal state and rotates it in needed position and saves it does that for every flight.
        private void RotateImages() 
        {
            var positions = pR.GetPositionsFromDB();
            foreach (Position position in positions)
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(@"D:\Faks\Druga godina\Treci Semestar\Programiranje_u_NET_okolini\Konstrukcijska_Vjezba\FlightTracker\FlightTracker\Resources\plane_16x16.png");
                //create an empty Bitmap image
                Bitmap bmp = new Bitmap(img.Width, img.Height);

                //turn the Bitmap into a Graphics object
                Graphics gfx = Graphics.FromImage(bmp);

                //now we set the rotation point to the center of our image
                gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

                //now rotate the image
                gfx.RotateTransform(Convert.ToSingle(position.trueTrack));

                gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

                //set the InterpolationMode to HighQualityBicubic so to ensure a high
                //quality image once it is transformed to the specified size
                gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

                //now draw our new image onto the graphics object
                gfx.DrawImage(img, new System.Drawing.Point(0, 0));

                //dispose of our Graphics object
                gfx.Dispose();

                string nameOfImg = @"D:\Faks\Druga godina\Treci Semestar\Programiranje_u_NET_okolini\Konstrukcijska_Vjezba\FlightTracker\FlightTracker\Resources\imagesOfPlanes\" + position.positionId + ".png";
                bmp.Save(nameOfImg, ImageFormat.Png);
            }
        }
        //Creates a shape file that contains all flights lat and long points and then generates a feald in the table that contains all flights images
        private void CreatePointShapefile()
        {
            axMap1.Projection = tkMapProjection.PROJECTION_WGS84;
            axMap1.TileProvider = tkTileProvider.OpenStreetMap;
            var positions = pR.GetPositionsFromDB();
            var sfPoints = new Shapefile();
            sfPoints.CreateNewWithShapeID("", ShpfileType.SHP_POINT);
            // creating points and inserting them in the shape
            foreach (Position position in positions)
            {
                int count = 0;
                var pnt = new Point();
                pnt.x = Convert.ToDouble(position.longitude);
                pnt.y = Convert.ToDouble(position.latitude);
                Shape shp = new Shape();
                shp.Create(ShpfileType.SHP_POINT);
                int index = 0;
                shp.InsertPoint(pnt, ref index);
                sfPoints.EditInsertShape(shp, ref count);
                count++;
            }
            var _idShape = axMap1.AddLayer(sfPoints, true);
            int indexo = sfPoints.Table.FieldIndexByName["MWShapeId"];
            var names = new HashSet<string>();
            for (int i = 0; i < sfPoints.Table.NumRows; i++)
            {
                names.Add(sfPoints.Table.CellValue[indexo, i].ToString());
            }
            string[] files = Directory.GetFiles(@"D:\Faks\Druga godina\Treci Semestar\Programiranje_u_NET_okolini\Konstrukcijska_Vjezba\FlightTracker\FlightTracker\Resources\imagesOfPlanes");
            foreach (string file in files) 
            {
                string name = Path.GetFileNameWithoutExtension(file);
                if (Path.GetExtension(file).ToLower() == ".png" && names.Contains(name)) 
                {
                    MapWinGIS.Image img = new MapWinGIS.Image();
                    if (img.Open(file, ImageType.USE_FILE_EXTENSION, true, null))
                    {
                        ShapefileCategory ct = new ShapefileCategory();
                        ct = sfPoints.Categories.Add(name);
                        ct.DrawingOptions.PointType = tkPointSymbolType.ptSymbolPicture;
                        ct.DrawingOptions.PictureScaleX = 0.8;
                        ct.DrawingOptions.PictureScaleY = 0.8;
                        ct.DrawingOptions.DrawingMode = tkVectorDrawingMode.vdmGDIPlus;
                        sfPoints.CollisionMode = tkCollisionMode.AllowCollisions;
                        ct.Expression = "[MWShapeId]=" + name;
                        ct.DrawingOptions.Picture = img;

                        sfPoints.DefaultDrawingOptions = ct.DrawingOptions;
                    }
                }
            }
            sfPoints.Categories.ApplyExpressions();
            axMap1.KnownExtents = tkKnownExtents.keCroatia;
        }
    }
}
