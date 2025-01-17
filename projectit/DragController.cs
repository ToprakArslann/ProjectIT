using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectit
{
    // The DragController class enables dragging of a form via a control.
    public class DragController : Component
    {
        // Variable to hold the control that will be used to drag the form
        private Control controllerDrag;

        // Windows API call to send a message to the form (to start dragging the form)
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr a, int msg, int wParam, int lParam);

        // Windows API call to release capture, allowing dragging of the form
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        // Property to set and get the control that will trigger the drag
        public Control SelectControl
        {
            get { return controllerDrag; }
            set
            {
                // When a control is assigned, listen to its MouseDown event
                controllerDrag = value;
                controllerDrag.MouseDown += new MouseEventHandler(DragForm_MouseDown);
            }
        }

        // MouseDown event handler that initiates the form dragging when left mouse button is pressed
        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            // If the left mouse button is pressed
            if (e.Button == MouseButtons.Left)
            {
                // Release capture to allow form to be moved
                ReleaseCapture();
                // Send the command to the form to start moving (161: WM_SYSCOMMAND, 2: SC_MOVE)
                SendMessage(SelectControl.FindForm().Handle, 161, 2, 0);
            }
        }
    }
}
