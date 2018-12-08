using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace F2P.Narrative
{
    public class Section
    {
        private string _title;
        private List<Choice> _choices;
        private List<string> _lines;
        private bool _is_ending;

        public Section(string title)
        {
            _title = title;
        }

        public void AddLine(string line)
        {
            _lines.Add(line);
        }

        public void AddChoice(Choice new_choice)
        {
            _choices.Add(new_choice);
        }
    }
}
