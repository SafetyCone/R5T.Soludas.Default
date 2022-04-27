using System;

using R5T.Cambridge.Types;
using R5T.Vandalia;using R5T.T0064;


namespace R5T.Soludas.Default
{[ServiceImplementationMarker]
    public class VisualStudioSolutionFileValueEqualityComparer : IVisualStudioSolutionFileValueEqualityComparer,IServiceImplementation
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
