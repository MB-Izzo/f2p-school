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
    }
}
