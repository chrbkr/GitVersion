﻿using GitVersion.Command;

namespace GitVersion.Output.Project
{
    [Command("project", "Outputs version to project")]
    public record OutputProjectOptions : OutputOptions
    {
        [Option("--project-file", "The project file")]
        public string ProjectFile { get; init; } = default!;
    }
}