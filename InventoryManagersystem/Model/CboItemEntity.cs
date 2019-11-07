using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class CboItemEntity
    {
        private string _text = "";
        private string _Value = "";
        /// <summary>
        /// 显示值
        /// </summary>
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }
        /// <summary>
        /// 对象值
        /// </summary>
        public string Value
        {
            get { return this._Value; }
            set { this._Value = value; }
        }

        public override string ToString()
        {
            return this.Text.ToString();
        }
      
    }
}
