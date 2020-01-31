using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Cambridge.Types;
using R5T.Dacia;
using R5T.Vandalia;


namespace R5T.Soludas.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileValueEqualityComparer"/> implementation of <see cref="IVisualStudioSolutionFileValueEqualityComparer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultVisualStudioSolutionFileValueEqualityComparer(this IServiceCollection services,
            ServiceAction<IValueEqualityComparer<SolutionFile>> addSolutionFileValueEqualityComparer)
        {
            services
                .AddSingleton<IVisualStudioSolutionFileValueEqualityComparer, VisualStudioSolutionFileValueEqualityComparer>()
                .RunServiceAction(addSolutionFileValueEqualityComparer)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileValueEqualityComparer"/> implementation of <see cref="IVisualStudioSolutionFileValueEqualityComparer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IVisualStudioSolutionFileValueEqualityComparer> AddDefaultVisualStudioSolutionFileValueEqualityComparerAction(this IServiceCollection services,
            ServiceAction<IValueEqualityComparer<SolutionFile>> addSolutionFileValueEqualityComparer)
        {
            var serviceAction = new ServiceAction<IVisualStudioSolutionFileValueEqualityComparer>(() => services.AddDefaultVisualStudioSolutionFileValueEqualityComparer(
                addSolutionFileValueEqualityComparer));
            return serviceAction;
        }
    }
}
