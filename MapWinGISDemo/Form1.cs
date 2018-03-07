using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapWinGISDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add first layer to your map
            int intHandler1; //integer index to handle the layer
                             //create a new instance for MapWinGIS.Shapefile
                             //MapWinGIS.Shapefile  is a data provider for ESRI Shapefile
            MapWinGIS.Shapefile shapefile1 = new MapWinGIS.Shapefile();
            //Define the data source for MapWinGIS.Shapefile instance
            shapefile1.Open(@"D:\Projects\GIS\MapWinGISDemo\MapWinGISDemo\GISSampleData\base.shp", null);
            //display the layer on the map
            intHandler1 = axMap1.AddLayer(shapefile1, true);

            //Add second layer
            int intHandler2;
            MapWinGIS.Shapefile shapefile2 = new MapWinGIS.Shapefile();
            shapefile2.Open(@"D:\Projects\GIS\MapWinGISDemo\MapWinGISDemo\GISSampleData\nile.shp", null);
            intHandler2 = axMap1.AddLayer(shapefile2, true);

            //Set Filling color of the ploygon shapefile
            axMap1.set_ShapeLayerFillColor(intHandler1,
                (UInt32)(System.Drawing.ColorTranslator.ToOle
                        (System.Drawing.Color.SaddleBrown)));
            //Set the line color
            axMap1.set_ShapeLayerLineColor(intHandler2,
                (UInt32)(System.Drawing.ColorTranslator.ToOle
                        (System.Drawing.Color.Yellow)));
            //Set the line width
            axMap1.set_ShapeLayerLineWidth(intHandler2, 5);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void axMap1_MouseDownEvent(object sender, AxMapWinGIS._DMapEvents_MouseDownEvent e)
        {

        }

        private void toolCursor_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmNone;
        }

        private void toolZoomIn_Click(object sender, EventArgs e)
        {
            //axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomIn;
            axMap1.ZoomIn(45);
        }

        private void toolZoomOut_Click(object sender, EventArgs e)
        {
            //axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut;
            axMap1.ZoomOut(200);
        }

        private void toolPan_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmPan;
            
        }

        private void toolZoomExtent_Click(object sender, EventArgs e)
        {
            axMap1.ZoomToMaxExtents();
        }
    }
}
