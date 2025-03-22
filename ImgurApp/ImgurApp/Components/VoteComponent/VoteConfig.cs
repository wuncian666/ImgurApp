using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Components.VoteComponent
{
    public class VoteConfig
    {
        public VoteDirection Direction { get; set; }

        public Size RefSize { get; set; }

        public Size ContainerSize
        {
            get
            {
                if (Direction == VoteDirection.Horizontal)
                {
                    return new Size(RefSize.Width * 3, RefSize.Height);
                }
                else
                {
                    return new Size(RefSize.Width, RefSize.Height * 3);
                }
            }
        }

        public Size LabelSize
        {
            get
            {
                return new Size(RefSize.Width, RefSize.Width);
            }
        }

        public Font FrontSize { get; set; }

        public Font IConSize { get; set; }
    }
}