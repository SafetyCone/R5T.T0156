using System;

using R5T.T0143;


namespace R5T.T0156
{
    /// <summary>
    /// Attribute indicating a type is a draft documentation classes.
    /// Draft documentation types are quickly created and should be reviewed and relocated, and thus become full documentation classes.
    /// The marker attribute is useful for surveying assemblies and code, then building a catalogue of draft documentation classes as a kind of TODO list.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class DraftDocumentationMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        /// <summary>
        /// Allows specifying that a class is *not* a draft documentation class.
        /// This is useful for marking types that end up canonical draft documentation code file locations, but are not actually draft documentation types.
        /// </summary>
        public bool IsDraftDocumentation { get; }


        public DraftDocumentationMarkerAttribute(
            bool isDraftDocumentation = true)
        {
            this.IsDraftDocumentation = isDraftDocumentation;
        }
    }
}
