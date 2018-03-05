using System;
using PCSC.BackPortDotNet35;

namespace PCSC
{
    /// <summary>
    /// Smart card context factory
    /// </summary>
    public class ContextFactory : IContextFactory
    {
        private static readonly BackPortDotNet35.Lazy<IContextFactory> _instance = new BackPortDotNet35.Lazy<IContextFactory>(() => new ContextFactory());

        /// <summary>
        /// Default factory instance.
        /// </summary>
        public static IContextFactory Instance => _instance.Value;

        /// <summary>
        /// Create and establish a new smart card context.
        /// </summary>
        /// <param name="scope">Scope of the establishment. This can either be a local or remote connection.</param>
        /// <returns>A new established smart card context</returns>
        public ISCardContext Establish(SCardScope scope) {
            var context = new SCardContext();
            context.Establish(scope);
            return context;
        }
    }
}
