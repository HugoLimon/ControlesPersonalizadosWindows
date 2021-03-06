﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeLine
{
    public partial class TimeLine : UserControl
    {
        DateTime HoraInicial = new DateTime(1996, 01, 27, 0, 0, 0);
        DateTime HoraFinal = new DateTime(1996, 01, 27, 9, 0, 0);
        Color colorColumnaReferencia = Color.Transparent;//El color de la columna de referencia 0 
        Color colorPistaTimeline = Color.Transparent;//El color de la columna de referencia 0 
        Padding marginLabelColumnaReferencia = new Padding(0, 0, 0, 0);
        Padding marginRenglon = new Padding(0, 0, 0, 0);
        Padding paddingPanelRenglones = new Padding(0, 0, 0, 0);
        Padding marginHeaders = new Padding(0, 0, 0, 0);
        Font fontHeaders= new Font(FontFamily.GenericMonospace, 8.5F, FontStyle.Regular, GraphicsUnit.Pixel);
        Font fontColumnaReferencia = new Font(FontFamily.GenericMonospace, 8.5F,FontStyle.Regular, GraphicsUnit.Pixel);
        Color foreColorHeaders = Color.White;
        Color foreColorColReferencia = Color.White;
        int heigth = 0;
        int _cheight = 0;
        List<ControlTimeLine> lstControltimeLine = new List<ControlTimeLine>();
        public TimeLine()
        {
            InitializeComponent();
            this.SetRows = new List<string>();
            this.SetColumns = 12;

        }

        //Style
        [Description("Cambia el color de fondo del panel de renglones"), Category("Style")]
        public Color BackColorPanelRows
        {
            get { return PanelRows.BackColor; }
            set { PanelRows.BackColor = value; }
        }
        [Description("Cambia el color de fondo de las cabeceras  "), Category("Style")]
        public Color BackColorPanelColumns
        {
            get { return panelColumns.BackColor; }
            set { panelColumns.BackColor = value; }
        }
        [Description("Cambia el color de fondo principal  "), Category("Style")]
        public Color BackColorPanelTrasero
        {
            get { return panelTrasero.BackColor; }
            set { panelTrasero.BackColor = value; }
        }
        [Description("Cambia el color de la columna de referencia principal  "), Category("Style")]
        public Color BackColorColumnaReferencia
        {
            get { return colorColumnaReferencia; }
            set
            {
                colorColumnaReferencia = value;
                //
                colorPistaTimeline = value;
                foreach (Control _c in PanelRows.Controls)
                {
                    if (Convert.ToInt32(_c.Tag) == -1)
                        _c.BackColor = colorPistaTimeline;
                }
            }
        }
        [Description("Cambia el color de fondo principal  "), Category("Style")]
        public Color BackColorPistaTimeLine
        {
            get { return colorPistaTimeline; }
            set
            {
                colorPistaTimeline = value;
                foreach (Control _c in PanelRows.Controls)
                {
                    if (_c.Tag != null)
                    {
                        if(Convert.ToInt32(_c.Tag) != -1)
                            _c.BackColor = colorPistaTimeline;
                    }
                        
                }
            }
        }
        [Description("MArgen Renglones"), Category("Style")]
        public Padding marginRenglonT
        {
            get { return marginRenglon; }
            set
            {
                marginRenglon = value;
                foreach (Control _c in PanelRows.Controls)
                {
                    if (_c.Tag != null)
                    {
                        if (Convert.ToInt32(_c.Tag) != -1)
                        { 
                            _c.Margin = marginRenglon;
                        }
                    }

                }
            }
        }
        [Description("Padding Columna Referencia"), Category("Style")]
        public Padding marginColumnaReferencia
        {
            get { return marginLabelColumnaReferencia; }
            set
            {
                marginLabelColumnaReferencia = value;
                foreach (Control _c in PanelRows.Controls)
                {
                    if (_c.Tag != null)
                    {
                        if (Convert.ToInt32(_c.Tag) == -1)
                            _c.Margin = marginLabelColumnaReferencia;
                    }

                }
            }
        }
        [Description(" Margen timeline"), Category("Style")]
        public Padding MargenPanelTimeLine
        {
            get { return paddingPanelRenglones; }
            set
            {
                paddingPanelRenglones = value;
                PanelRows.Margin = value;
            }
        }
        [Description("Margen Headers"), Category("Style")]
        public Padding MargenHeaders
        {
            get { return marginHeaders; }
            set
            {
                marginHeaders = value;
                panelColumns.Margin = value;
            }
        }
        [Description("Fuente texto headers"), Category("Style")]
        public Font FontHeaders
        {
            get { return fontHeaders; }
            set
            {
                fontHeaders = value;
                foreach (Control _c in panelColumns.Controls)
                {
                    _c.Font = fontHeaders;

                }
                
            }
        }
        [Description("Fuente texto columna referencia"), Category("Style")]
        public Font FontColumnReferencia
        {
            get { return fontColumnaReferencia; }
            set
            {
                fontColumnaReferencia = value;
                foreach (Control _c in PanelRows.Controls)
                {
                    if (_c.Tag != null)
                    {
                        if (Convert.ToInt32(_c.Tag) == -1)
                            _c.Font = fontColumnaReferencia;
                    }

                }

            }
        }
        [Description("Color texto headers"), Category("Style")]
        public Color FroreColorHeaders
        {
            get { return foreColorHeaders; }
            set
            {
                foreColorHeaders = value;
                foreach (Control _c in panelColumns.Controls)
                {
                    _c.ForeColor = foreColorHeaders;

                }

            }
        }
        [Description("Color texto columna referencia"), Category("Style")]
        public Color ForeColorColReferencia
        {
            get { return foreColorColReferencia; }
            set
            {
                foreColorColReferencia = value;
                foreach (Control _c in PanelRows.Controls)
                {
                    if (_c.Tag != null)
                    {
                        if (Convert.ToInt32(_c.Tag) == -1)
                            _c.ForeColor = foreColorColReferencia;
                    }

                }

            }
        }
        [Description("Color texto columna referencia"), Category("Style")]
        public Size SizePanelHeaders
        {
            get { return panelColumns.Size; }
            set
            {
                panelColumns.Size = value;
            }
        }
        //SIZE
        [Description("Fija los renglones con su nombre"), Category("Size")]
        public List<string> SetRows
        {
            set
            {
                if (value.Count > 0)
                {
                    PanelRows.RowStyles.Clear();
                    PanelRows.RowCount = value.Count;
                    PanelRows.Controls.Clear();
                    for (int i = 0; i < value.Count; i++)
                    {

                        PanelRows.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                        Panel panel = new Panel();
                        panel.Tag = i + 1;
                        panel.BackColor = colorPistaTimeline;
                        panel.Dock = DockStyle.Fill;
                        panel.Margin = marginRenglon;
                        PanelRows.Controls.Add(panel, 1, i);
                        

                        Label _label = new Label();
                        _label.Font = fontColumnaReferencia;
                        _label.Text = value[i];//(i + 1).ToString();
                        _label.Dock = DockStyle.Fill;
                        _label.TextAlign = ContentAlignment.MiddleCenter;
                        _label.BackColor = colorColumnaReferencia;
                        _label.Margin = marginLabelColumnaReferencia;
                        _label.Tag = -1;
                        PanelRows.Controls.Add(_label, 0, i);

                    }

                }

            }
        }
        [Description("Fija los renglones con su nombre"), Category("Size")]
        public int getRowsCount
        {
            get { return PanelRows.RowCount; }
        }
        [Description("Fija la cantidad de columnas. El valor maxímo es 24"), Category("Size")]
        public int SetColumns
        {
            get { return panelColumns.ColumnCount - 1; }
            set
            {
                if (value > 0 && value<=24)
                {
                    panelColumns.ColumnStyles.Clear();
                    panelColumns.Controls.Clear();
                    panelColumns.ColumnCount = value + 1;
                    panelColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5));
                    for (int i = 0; i < value; i++)
                    {
                        panelColumns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (95/(float)value)));
                    }
                    Label _lbl;
                    panelColumns.Controls.Clear();
                    for (int i = 0; i < panelColumns.ColumnCount - 1; i++)
                    {
                        _lbl = new Label();
                        _lbl.Font = fontColumnaReferencia;
                        _lbl.Dock = DockStyle.Fill;
                        _lbl.TextAlign = ContentAlignment.MiddleCenter;
                        _lbl.BackColor = Color.Transparent;
                        _lbl.Text = HoraInicial.AddHours(i).ToShortTimeString();
                        _lbl.Font = FontHeaders;
                        _lbl.AutoSize = false;
                        HoraFinal = HoraInicial.AddHours(i);
                        panelColumns.Controls.Add(_lbl, i + 1, 0);
                    }
                    TimeLine_Resize(new object(), new EventArgs());
                }

            }
        }
        [Description("Fija la hora de inicio de la linea del tiempo"), Category("Size")]
        public int StartHour
        {
            get { return HoraInicial.Hour; }
            set
            {
                Label _lbl;
                HoraInicial = new DateTime(1996, 01, 27, value, 0, 0);
                panelColumns.Controls.Clear();
                for (int i = 0; i < panelColumns.ColumnCount - 1; i++)
                {
                    _lbl = new Label();
                    _lbl.Text = HoraInicial.AddHours(i).ToShortTimeString();
                    panelColumns.Controls.Add(_lbl, i + 1, 0);
                }
            }
        }
        [Description("Fija el intervalo de la transición de los controles sobre el time line"), Category("Data")]
        public int Interval
        {
            get { return bunifuTransition1.Interval; }
            set
            {
                bunifuTransition1.Interval = value;
            }
        }
        [Description("Fija el timeStep de la transición de los controles sobre el time line"), Category("Data")]
        public float Timestep
        {
            get { return bunifuTransition1.TimeStep; }
            set
            {
                bunifuTransition1.TimeStep = value;
            }
        }
        [Description("Muestra la linea representativa de la hora actual"), Category("Data")]
        public bool RealTimeLine
        {
            get { return Line.Visible; }
            set
            {
                Line.Visible = true;               
            }
        }
        [Description("Fija el MaxAnimationTime de la transición de los controles sobre el time line"), Category("Data")]
        public int MaxAnimationTime
        {
            get { return bunifuTransition1.MaxAnimationTime; }
            set
            {
                bunifuTransition1.MaxAnimationTime = value;
            }
        }


        //Data
        [Description("Agrega el control sobre la linea del tiempo, este contrl se transformará automaticamente"), Category("Data")]
        public void AddControl(ControlTimeLine _control)
        {

            AgregaControl(_control);         
            lstControltimeLine.Add(_control);
            _control.control.Click += ClickContrl;
        }
        public void cleanAllTimeLines()
        {
            foreach (Control _c in PanelRows.Controls)
            {
                if (_c.Tag != null)
                    if (Convert.ToInt32(_c.Tag) !=-1)
                    {
                        _c.Controls.Clear();
                    }
            }
        }
        public void cleanTimeLine(int i)
        {
            foreach (Control _c in PanelRows.Controls)
            {
                if (_c.Tag != null)
                    if (Convert.ToInt32(_c.Tag) != i)
                    {
                        _c.Controls.Clear();
                    }
            }
        }
        private KeyValuePair<int, int> CalculaPos(DateTime _horaInicio, int _duracion)
        {
            double _pixHora = (panelColumns.Width * 0.95) / (panelColumns.ColumnCount - 1);
            double _pixMin = _pixHora / 60;
            int _posXi = Convert.ToInt32((_pixMin * _horaInicio.Minute) + (_pixHora * (_horaInicio.Hour - HoraInicial.Hour)));
            int _posXf = Convert.ToInt32(_pixMin * _duracion);

            return new KeyValuePair<int, int>(_posXi, _posXf);
        }
        private void AgregaControl(ControlTimeLine _control)
        {
            int _duracion = Convert.ToInt32(_control.duracionMinutos);
            int _row = Convert.ToInt32(_control.row);
            KeyValuePair<int, int> _kvp = CalculaPos(new DateTime(1996, 01, 27, _control.horaInicio, _control.minutosInicio, 0), _duracion);
            _control.control.Visible=false;
            

            foreach (Control _c in PanelRows.Controls)
            {
                if (_c.Tag != null)
                    if (Convert.ToInt32(_c.Tag.ToString()) == _control.row)
                    {
                        _c.Controls.Add(_control.control);
                        _control.control.Width = _kvp.Value;
                        _control.control.Height =_c.Height- 6;
                        _control.control.Location = new Point(_kvp.Key, 3);
                        _control.control.Visible = true;
                        //bunifuTransition1.Show(_control.control);
                    }
            }

        }
        private void TimeLine_Resize(object sender, EventArgs e)
        {
            foreach (Control _c in PanelRows.Controls)
            {
                if (_c.Tag != null)
                {
                    _c.Controls.Clear();
                }
            }
            foreach (ControlTimeLine _ct in lstControltimeLine)
            {
                AgregaControl(_ct);
            }
            this.Refresh();
        }
        private void ClickContrl(object obj, EventArgs e)
        {
            //PanelRows.BackColor = Color.Red;
        }
        public void Corrimiento()
        {
            foreach(ControlTimeLine _ct in lstControltimeLine)
            {
                KeyValuePair<int, int> _kvp = CalculaPos(new DateTime(1996, 01, 27, _ct.horaInicio, _ct.minutosInicio, 0), Convert.ToInt32(_ct.duracionMinutos));
                _ct.control.Visible = false;

                foreach (Control _c in PanelRows.Controls)
                {
                    if (_c.Tag != null)
                        if (Convert.ToInt32(_c.Tag) == _ct.row)
                        {
                            
                            _ct.control.Width = _kvp.Value;
                            _ct.control.Height = _c.Height - 6;
                            _ct.control.Location = new Point(_kvp.Key, 3);
                            _ct.control.Visible = true;
                        }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            KeyValuePair<int, int> _kvp=CalculaPos(DateTime.Now, 10);
            Line.Location=new Point(Convert.ToInt32(panelColumns.Width * 0.05) + _kvp.Key);
        }
    }
}
