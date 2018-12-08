using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace F2P.Narrative
{
    public class Choice
    {
        private string _text;
        private Section _link;
        private bool _is_ending;

        public Choice(string text, Section link)
        {
            _text = text;
            _link = link;
        }
    }
}
