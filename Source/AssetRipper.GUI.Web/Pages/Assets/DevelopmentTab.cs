﻿using AssetRipper.Assets;

namespace AssetRipper.GUI.Web.Pages.Assets;

internal sealed class DevelopmentTab(IUnityObjectBase asset) : AssetTab
{
	public override string DisplayName => Localization.AssetTabDevelopment;

	public override string HtmlName => "development";

	public override bool Enabled => true;

	public override void Write(TextWriter writer)
	{
		using (new Table(writer).WithClass("table").End())
		{
			using (new Tbody(writer).End())
			{
				using (new Tr(writer).End())
				{
					new Th(writer).Close(Localization.CsharpType);
					new Td(writer).Close(asset.GetType().Name);
				}
				using (new Tr(writer).End())
				{
					new Th(writer).Close(Localization.Guid);
					new Td(writer).Close(asset.GUID.ToString());
				}
			}
		}
	}
}
