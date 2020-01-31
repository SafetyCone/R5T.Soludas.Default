using System;

using R5T.Cambridge.Types;
using R5T.Vandalia;


namespace R5T.Soludas.Default
{
    public class VisualStudioSolutionFileValueEqualityComparer : IVisualStudioSolutionFileValueEqualityComparer
    {
        private IValueEqualityComparer<SolutionFile> SolutionFileValueEqualityComparer { get; }


        public VisualStudioSolutionFileValueEqualityComparer(IValueEqualityComparer<SolutionFile> solutionFileValueEqualityComparer)
        {
            this.SolutionFileValueEqualityComparer = solutionFileValueEqualityComparer;
        }

        public bool Equals(SolutionFile x, SolutionFile y)
        {
            var equals = this.SolutionFileValueEqualityComparer.Equals(x, y);
            return equals;
        }
    }
}
