﻿using System;

namespace PamNHibernateDemos

{

    public class TypeStructure
    {
        public virtual int codeTypeStructure { get; set; }
        public virtual string libelleTypeStructure { get; set; }


        public TypeStructure()
        {

        }

        // ToString 
        public override string ToString()
        {
            return string.Format("[{0}]", libelleTypeStructure);
        }
 
    }
} 