using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;

namespace MaSureApox
{
    public partial class Graphic : Form
    {
        private double[] _xDano;
        private double[] _xKvadr;
        private double[] _xLiner;
        private double[] _yDano;
        private double[] _yKvadr;
        private double[] _yLiner;
        private LineSeries lineSeries;
        //private LineSeries lineSeries1;
        private LineSeries lsKvadr;
        private LineSeries lsLiner;

        public Graphic()
        {
            InitializeComponent();
        }

        public Graphic(double[] xDano, double[] yDano, double[] xKvadr, double[] yKvadr, double[] xLiner, double[] yLiner)
        {
            InitializeComponent();
            _xDano = xDano;
            _xKvadr = xKvadr;
            _xLiner = xLiner;
            _yDano = yDano;
            _yKvadr = yKvadr;
            _yLiner = yLiner;

        }

        private void Graphic_Load(object sender, EventArgs e)
        {
            var myModel = new PlotModel("Graphics");
            lineSeries = new LineSeries
            {
                //Color = OxyColor.Parse("Blue"),
                Title = "Исходные данные"
            };
            lsLiner = new LineSeries
            {
                //Color = OxyColor.Parse("Red"),
                Title = "Линейный сплайн"
            };
            lsKvadr = new LineSeries
            {
                Title = "МНК"
            };
            lsLiner.Points.Clear();
            lsKvadr.Points.Clear();
            lineSeries.Points.Clear();
            if (_xDano != null)
            {
                for (int i = 0; i < _xDano.Length; i++)
                {
                    lineSeries.Points.Add(new DataPoint(_xDano[i], _yDano[i]));
                }
                myModel.Series.Add(lineSeries);
            }
            if (_xLiner != null)
            {
                for (int i = 0; i < _xLiner.Length; i++)
                {
                    lsLiner.Points.Add(new DataPoint(_xLiner[i], _yLiner[i]));
                }
                myModel.Series.Add(lsLiner);
            }
            if (_xKvadr != null)
            {
                for (int i = 0; i < _xKvadr.Length; i++)
                {
                    lsKvadr.Points.Add(new DataPoint(_xKvadr[i],_yKvadr[i]));
                }
                myModel.Series.Add(lsKvadr);
            }
            
            myModel.PlotType = PlotType.XY;
            this.plot1.Model = myModel;
        }
    }
}
