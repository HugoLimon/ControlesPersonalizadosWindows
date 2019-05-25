using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeLine
{
    public class ControlTimeLine
    {
        public Control control;
        public Type tipoControl;
        public int horaInicio;
        public int duracionMinutos;
        public int minutosInicio;
        public int row;
        public ControlTimeLine(Control _control, Type _tipo, int _horaInicio, int _minutosInicio, int _duracion, int _Row)
        {
            control = _control;
            tipoControl = _tipo;
            horaInicio = _horaInicio;
            minutosInicio = _minutosInicio;
            duracionMinutos = _duracion;
            row = _Row;
        }
    }
}
