﻿using Microsoft.CodeAnalysis.Options;

namespace Microsoft.CodeAnalysis.Shared.Options
{
    internal class AddImportOptions
    {
        public static PerLanguageOption<bool> SuggestForTypesInReferenceAssemblies =
            new PerLanguageOption<bool>(nameof(AddImportOptions), nameof(SuggestForTypesInReferenceAssemblies), defaultValue: false,
                persistences: new RoamingProfilePersistence("TextEditor.%LANGUAGE%.Specific.SuggestForTypesInReferenceAssemblies"));

        public static PerLanguageOption<bool> SuggestForTypesInNuGetPackages =
            new PerLanguageOption<bool>(nameof(AddImportOptions), nameof(SuggestForTypesInNuGetPackages), defaultValue: false,
                persistences: new RoamingProfilePersistence("TextEditor.%LANGUAGE%.Specific.SuggestForTypesInNuGetPackages"));
    }
}
