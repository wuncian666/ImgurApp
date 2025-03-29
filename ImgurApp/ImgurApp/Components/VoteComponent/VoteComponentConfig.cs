using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApp.Components.VoteComponent
{
    public class VoteComponentConfig
    {
        private Font _fontSize;

        // 邊長
        private int _iconSideLength;

        private Size _refContainer;

        public VoteDirection Direction { get; set; }

        private Size _refContainerSize;

        public Size RefContainerSize
        {
            set
            {
                if (Direction == VoteDirection.Horizontal)
                {
                    this._iconSideLength = value.Height;
                }
                else
                {
                    this._iconSideLength = value.Width;
                }
                this._refContainer = value;
                this._refContainerSize = value;
            }
        }

        public Size ContainerSize
        {
            get
            {
                if (Direction == VoteDirection.Horizontal)
                {
                    return new Size(this._iconSideLength * 4, this._iconSideLength);
                }
                else
                {
                    return new Size(this._iconSideLength, this._iconSideLength * 4);
                }
            }
        }

        // 正方形
        public Size IconLabelSize
        {
            get
            {
                if (Direction == VoteDirection.Horizontal)
                {
                    return new Size(this._refContainer.Height, this._refContainer.Height);
                }
                else
                {
                    return new Size(this._refContainer.Width, this._refContainer.Width);
                }
            }
        }

        // 長方形
        public Size ScoreLabelSize
        {
            get
            {
                if (Direction == VoteDirection.Horizontal)
                {
                    return new Size(this._refContainer.Height * 2, this._refContainer.Height);
                }
                else
                {
                    return new Size(this._refContainer.Width, this._refContainer.Width * 2);
                }
            }
        }

        public Font FontSize
        {
            get => this._fontSize;
            set => _fontSize = value;
        }

        public Font IConSize
        {
            get => _fontSize != null ? new Font(this._fontSize.FontFamily, this._fontSize.Size + 4) : null;
        }
    }
}