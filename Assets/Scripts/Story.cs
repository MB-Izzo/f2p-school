using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace F2P.Narrative
{
    public class Story
    {
        private List<Section> sections;
        public Story()
        {

        }

        public void AddSection(Section new_section)
        {
            sections.Add(new_section);
        }

    }

}
