﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RandomPowerGates
{
    class TextManager
    {
        private SpriteFont textFont;
        public List<StaticText> staticTexts = new List<StaticText>();

        public TextManager(SpriteFont spriteFont)
        {
            textFont = spriteFont;
        }

        public void addStaticText(string text, Vector2 textPosition, Color textColor)
        {
            staticTexts.Add(new StaticText(text, textPosition, textColor));
        }

        public void addDynamicText()
        {
            throw new NotImplementedException();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach(StaticText st in staticTexts)
            {
                spriteBatch.DrawString(textFont, st.text, st.textPosition, st.textColor);
            }
        }
    }

    class StaticText
    {
        public string text;
        public Vector2 textPosition;
        public Color textColor;
        public StaticText(string text, Vector2 textPosition, Color textColor)
        {
            this.text = text;
            this.textPosition = textPosition;
            this.textColor = textColor;
    }
    }
}
