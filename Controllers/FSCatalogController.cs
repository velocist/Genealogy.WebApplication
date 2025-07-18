﻿using velocist.Services.Json.Serialization;

namespace Genealogy.WebApplication.Controllers {

	/// <summary>
	/// Resources controller
	/// </summary>
	/// <seealso cref="Controller" />
	public class FSCatalogController : BaseServiceController<FSCatalogController, FSCatalogModel, FSCatalog> {

		/// <summary>
		/// Initializes a new instance of the <see cref="FSCatalogController"/> class.
		/// </summary>
		/// <param name="sharedTranslations">The shared translations.</param>
		/// <param name="viewTranslates">The view translates.</param>
		/// <param name="date">The date.</param>
		/// <param name="renderView">The render view.</param>
		/// <param name="baseService">The base service.</param>
		public FSCatalogController(IStringLocalizer<SharedTranslations> sharedTranslations, IStringLocalizer<ViewsTranslations> viewTranslates, IDateTime date, IViewRender renderView, FSCatalogService baseService)
			: base(sharedTranslations, viewTranslates, date, renderView, "FSCatalog") {
			var json = System.IO.File.ReadAllText("./Views/FSCatalog/_Configure.json");
			Views = JsonHelper<ViewModel>.DeserializeToObject(json, false);
		}

	}
}
