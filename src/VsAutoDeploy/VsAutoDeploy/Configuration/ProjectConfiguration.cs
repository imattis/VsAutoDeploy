﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace VsAutoDeploy
{
    public class ProjectConfiguration
    {
        public bool IsEnabled { get; set; } = true;

        public string ProjectName { get; set; }

        public List<string> Files { get; private set; } = new List<string>();

        public bool IncludeSubDirectories { get; set; }
    }
}