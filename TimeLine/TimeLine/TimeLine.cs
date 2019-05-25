using System;
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
            this.SetRows = 1;
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
                    if ((int)_c.Tag == -1)
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
                        if((int)_c.Tag != -1)
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
                        if ((int)_c.Tag != -1)
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
                        if ((int)_c.Tag == -1)
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
                        if ((int)_c.Tag == -1)
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
                        if ((int)_c.Tag == -1)
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
        [Description("Fija la cantidad de renglones"), Category("Size")]
        public int SetRows
        {
            get { return PanelRows.RowCount; }
            set
            {
                if (value > 0)
                {
                    PanelRows.RowStyles.Clear();
                    PanelRows.RowCount = value;
                    PanelRows.Controls.Clear();
                    for (int i = 0; i < value; i++)
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
                        _label.Text = (i + 1).ToString();
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


        //Data
        [Description("Agrega el control sobre la linea del tiempo, este contrl se transformará automaticamente"), Category("Data")]
        public void AddControl(ControlTimeLine _control)
        {
            if (HoraInicial.Hour<=_control.horaInicio && HoraFinal.Hour>=_control.horaInicio)
            {
                AgregaControl(_control);
            } 
            lstControltimeLine.Add(_control);
            _control.control.Click += ClickContrl;
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
            
            

            foreach (Control _c in PanelRows.Controls)
            {
                if (_c.Tag != null)
                    if ((int)_c.Tag == _control.row)
                    {
                        _c.Controls.Add(_control.control);
                        _control.control.Width = _kvp.Value;
                        _control.control.Height =_c.Height- 6;
                        _control.control.Location = new Point(_kvp.Key, 3);
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
        }
        private void ClickContrl(object obj, EventArgs e)
        {
            //PanelRows.BackColor = Color.Red;
        }

    }
}
