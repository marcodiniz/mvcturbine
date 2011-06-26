﻿namespace MvcTurbine.Web.Modules {
	using System.Collections.ObjectModel;
	using System.Web;

	public interface IHttpModuleManager {
		ReadOnlyCollection<IHttpModule> Modules { get; }
		void InitializeModules(HttpApplication application);
	    void DisposeModules(HttpApplication application);
	}
}