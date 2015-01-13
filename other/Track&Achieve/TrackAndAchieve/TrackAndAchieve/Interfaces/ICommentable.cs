// <copyright file="ICommentable.cs" company="sworn to secrecy">*</copyright>
// <author>My name is Legion: for we are many.</author>

namespace TrackAndAchieve.Interfaces
{
    /// <summary>Guarantees the ability of a class to work with comments.</summary>
    public interface ICommentable
    {
        /// <summary>Deletes all comments for this object.</summary>
        void ClearComments();

        /// <summary>Adds a comment to a this object.</summary>
        /// <param name="commentArg">comment as string value</param>
        void AddComment(string commentArg);
    }
}
