using System;

using R5T.T0143;


namespace R5T.T0156
{
    /// <summary>
    /// Attribute indicating a type is a documentation class.
    /// The marker attribute is useful for surveying assemblies and code, then building a catalogue of documentation classes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class DocumentationMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        /// <summary>
        /// Allows specifying that a class is *not* a documentation class.
        /// This is useful for marking types that end up canonical documentation class code file locations, but are not actually documentation classes worthy of surveying.
        /// </summary>
        public bool IsDocumentation { get; }


        public DocumentationMarkerAttribute(
            bool isDocumentation = true)
        {
            this.IsDocumentation = isDocumentation;
        }
    }
}
