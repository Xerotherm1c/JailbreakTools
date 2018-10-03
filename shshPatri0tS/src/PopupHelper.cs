using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace shshPatri0tS {

    class PopupHelper {

        public static PopupNotifier GeneratePopup(string content, string title = "", int delay = 5000) {

            title = title.Trim();
            content = content.Trim();
            delay = (delay > 0 ? delay : 5000);

            PopupNotifier popupSuccess = new PopupNotifier();

            popupSuccess.Delay = delay;

            popupSuccess.ShowGrip = false;
            popupSuccess.HeaderHeight = 1;
            popupSuccess.BodyColor = System.Drawing.Color.FromArgb(35, 35, 35);
            popupSuccess.GradientPower = 0;


            popupSuccess.TitleText = (title.Length > 0 ? title : "shsh Patri0tS");

            popupSuccess.TitleColor = System.Drawing.Color.White;
            popupSuccess.TitleFont = new System.Drawing.Font("Arial", 16);
            popupSuccess.TitlePadding = new Padding(10, 10, 10, 5);


            popupSuccess.ContentText = content;

            popupSuccess.ContentColor = System.Drawing.Color.LightGray;
            popupSuccess.ContentFont = new System.Drawing.Font("Arial", 12);
            popupSuccess.ContentPadding = new Padding(10);

            return popupSuccess;

        }

    }

}
