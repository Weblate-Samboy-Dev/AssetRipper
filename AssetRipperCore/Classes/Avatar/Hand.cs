﻿using AssetRipper.Core.IO.Asset;
using AssetRipper.Core.Project;
using AssetRipper.Yaml;
using AssetRipper.Yaml.Extensions;

namespace AssetRipper.Core.Classes.Avatar
{
	public sealed class Hand : IAssetReadable, IYAMLExportable
	{
		public void Read(AssetReader reader)
		{
			HandBoneIndex = reader.ReadInt32Array();
		}

		public YAMLNode ExportYAML(IExportContainer container)
		{
			YAMLMappingNode node = new YAMLMappingNode();
			node.Add(HandBoneIndexName, HandBoneIndex.ExportYAML(true));
			return node;
		}

		public int[] HandBoneIndex { get; set; }

		public const string HandBoneIndexName = "m_HandBoneIndex";
	}
}
