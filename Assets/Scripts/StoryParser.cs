using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using F2P.Helpers;
using System;

namespace F2P.Narrative
{
    /// <summary>
    /// Parse a story and creates Sections and Choices classes.
    /// </summary>
    public class StoryParser : MonoBehaviour
    {
        [SerializeField]
        private TextAsset _file;
        private string[] _lines;

        private int _curr_line_idx = 0;

        private Story _story;

        private void Start()
        {
            _story = new Story();
            _lines = _file.text.Split('\n');
            CreateSection(_curr_line_idx);
        }

        private void CreateSection(int idx)
        {
            Section section = null;
            Match result = Regex.Match(_lines[idx], RegexPatterns.section);
            if (result.Success)
            {
                string clean_name = CleanSectionName(result.Value);
                print(clean_name);
                section = new Section(clean_name);
                
            }

        }

        private string CleanSectionName(string unclean_name)
        {
            return unclean_name.Trim(new Char[] { ' ', '^' }).ToLower();
        }


    }
}
