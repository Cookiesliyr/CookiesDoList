using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer2 {
	public class ControlResizer {
        public static Dictionary<Control, byte> CRAr = new Dictionary<Control, byte>();
        public static Dictionary<Control, Action> CRActionAr = new Dictionary<Control, Action>();
        private static Point _cursorStartPoint;
        public static bool _resizing;
        private static Size _currentControlStartSize;
        internal static bool MouseIsInLeftEdge { get; set; }
        internal static bool MouseIsInRightEdge { get; set; }
        internal static bool MouseIsInTopEdge { get; set; }
        internal static bool MouseIsInBottomEdge { get; set; }

		/// <summary> Make it possible to resize a control by dragging its edges by mouse </summary>
		/// <param name="control">The Control that you want to be resized</param>
		/// <param name="sides">Which side you want it to be resizable: Top=1 Bottom=2 Left=4 Right=8</param>
		/// <param name="CRA">What to do based on the resize direction</param>
        internal static void Init(Control control, byte sides = 15, Action CRA = null) {
            if (CRAr.ContainsKey(control)) return;
            if (CRA != null) CRActionAr.Add(control, CRA);
            CRAr.Add(control, sides);
            Init(control, control); 
        }

        internal static void Init(Control control, Control container) {
            _resizing = false; _cursorStartPoint = Point.Empty;
            MouseIsInLeftEdge = false; MouseIsInRightEdge = false; MouseIsInTopEdge = false; MouseIsInBottomEdge = false;
            control.MouseDown += (sender, e) => StartMovingOrResizing(control, e);
            control.MouseUp += (sender, e) => StopDragOrResizing(control);
            control.MouseMove += (sender, e) => MoveControl(container, e);
        }

        private static void UpdateMouseEdgeProperties(Control control, Point mouseLocationInControl) {
            MouseIsInTopEdge    = Math.Abs(mouseLocationInControl.Y ) <= 5                 & ((CRAr[control] & 1) == 1);
            MouseIsInBottomEdge = Math.Abs(mouseLocationInControl.Y - control.Height) <= 5 & ((CRAr[control] & 2) == 2);
            MouseIsInLeftEdge   = Math.Abs(mouseLocationInControl.X) <= 5                  & ((CRAr[control] & 4) == 4);
            MouseIsInRightEdge  = Math.Abs(mouseLocationInControl.X - control.Width) <= 5  & ((CRAr[control] & 8) == 8);
        }

        private static void UpdateMouseCursor(Control control) {
            if (MouseIsInLeftEdge ) {
                if (MouseIsInTopEdge) control.Cursor = Cursors.SizeNWSE;
                else if (MouseIsInBottomEdge) control.Cursor = Cursors.SizeNESW;
                else control.Cursor = Cursors.SizeWE;
            }
            else if (MouseIsInRightEdge) {
                if (MouseIsInTopEdge) control.Cursor = Cursors.SizeNESW;
                else if (MouseIsInBottomEdge)control.Cursor = Cursors.SizeNWSE;
                else control.Cursor = Cursors.SizeWE;
            }
            else if (MouseIsInTopEdge || MouseIsInBottomEdge) control.Cursor = Cursors.SizeNS;
            else control.Cursor = Cursors.Default;
        }

        private static void StartMovingOrResizing(Control control, MouseEventArgs e) {
            if (MouseIsInRightEdge || MouseIsInLeftEdge || MouseIsInTopEdge || MouseIsInBottomEdge) {
                _resizing = true;
                _currentControlStartSize = control.Size;
            }
            _cursorStartPoint = new Point(e.X, e.Y);
            control.Capture = true;
        }

        private static void MoveControl(Control control, MouseEventArgs e) {
            if (!_resizing) {
                UpdateMouseEdgeProperties(control, new Point(e.X, e.Y));
                UpdateMouseCursor(control);
            }
            else {
                if (MouseIsInLeftEdge) {
                    if (MouseIsInTopEdge) {
                        control.Width  -= (e.X - _cursorStartPoint.X); control.Left += (e.X - _cursorStartPoint.X); 
                        control.Height -= (e.Y - _cursorStartPoint.Y); control.Top += (e.Y - _cursorStartPoint.Y);
                    }
                    else if (MouseIsInBottomEdge) {
                        control.Width -= (e.X - _cursorStartPoint.X); control.Left += (e.X - _cursorStartPoint.X);
                        control.Height = (e.Y - _cursorStartPoint.Y) + _currentControlStartSize.Height;                    
                    }
                    else { control.Width -= (e.X - _cursorStartPoint.X); control.Left += (e.X - _cursorStartPoint.X) ; }
                }
                else if (MouseIsInRightEdge) {
                    if (MouseIsInTopEdge) {
                        control.Width = (e.X - _cursorStartPoint.X) + _currentControlStartSize.Width;
                        control.Height -= (e.Y - _cursorStartPoint.Y); control.Top += (e.Y - _cursorStartPoint.Y);
                    }
                    else if (MouseIsInBottomEdge) {
                        control.Width = (e.X - _cursorStartPoint.X) + _currentControlStartSize.Width;
                        control.Height = (e.Y - _cursorStartPoint.Y) + _currentControlStartSize.Height;                    
                    }
                    else control.Width = (e.X - _cursorStartPoint.X)+_currentControlStartSize.Width;
                }
                else if (MouseIsInTopEdge) { control.Height -= (e.Y - _cursorStartPoint.Y); control.Top += (e.Y - _cursorStartPoint.Y); }
                else if (MouseIsInBottomEdge) control.Height = (e.Y - _cursorStartPoint.Y) + _currentControlStartSize.Height; 
                else  StopDragOrResizing(control); 
            }

        }

        private static void StopDragOrResizing(Control control) {
            if (CRActionAr.ContainsKey(control) && _resizing) CRActionAr[control].Invoke();
            _resizing = false;
            control.Capture = false;
            UpdateMouseCursor(control);
        }

        #region Save And Load

        private static List<Control> GetAllChildControls(Control control, List<Control> list) {
            List<Control> controls = control.Controls.Cast<Control>().ToList();
            list.AddRange(controls);
            return controls.SelectMany(ctrl => GetAllChildControls(ctrl, list)).ToList();
        }

        internal static string GetSizeAndPositionOfControlsToString(Control container) {
            List<Control> controls = new List<Control>();
            GetAllChildControls(container, controls);
            CultureInfo cultureInfo = new CultureInfo("en");
            string info = string.Empty;
            foreach (Control control in controls) {
                info += control.Name + ":" + control.Left.ToString(cultureInfo) + "," + control.Top.ToString(cultureInfo) + "," +
                        control.Width.ToString(cultureInfo) + "," + control.Height.ToString(cultureInfo) + "*";
            }
            return info;
        }
        
		internal static void SetSizeAndPositionOfControlsFromString(Control container, string controlsInfoStr) {
            List<Control> controls = new List<Control>();
            GetAllChildControls(container, controls);
            string[] controlsInfo = controlsInfoStr.Split(new []{"*"},StringSplitOptions.RemoveEmptyEntries );
            Dictionary<string, string> controlsInfoDictionary = new Dictionary<string, string>();
            foreach (string controlInfo in controlsInfo) {
                string[] info = controlInfo.Split(new [] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                controlsInfoDictionary.Add(info[0], info[1]);
            }
            foreach (Control control in controls){
                string propertiesStr;
                controlsInfoDictionary.TryGetValue(control.Name, out propertiesStr);
                string[] properties = propertiesStr.Split(new [] { "," }, StringSplitOptions.RemoveEmptyEntries);
                if (properties.Length == 4) {
                    control.Left = int.Parse(properties[0]);
                    control.Top = int.Parse(properties[1]);
                    control.Width = int.Parse(properties[2]);
                    control.Height = int.Parse(properties[3]);
                }
            }
        }

        #endregion
    }
}
