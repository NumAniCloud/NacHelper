﻿using NacHelpers.FilePath2.Interfaces;

namespace NacHelpers.FilePath2
{
	internal record RelativeDirectoryPath(string PathString) : IRelativeDirectoryPath;

	internal record AbsoluteDirectoryPath(string PathString) : IAbsoluteDirectoryPath;

	internal record RelativeFilePath(string PathString) : IRelativeFilePath;

	internal record AbsoluteFilePath(string PathString) : IAbsoluteFilePath;

	internal record PathWithExtension(string PathBase, FileExtension Extension)
	{
		public string PathString => PathBase + Extension.WithDot;
	}

	internal record RelativeFilePathExt(string PathBase, FileExtension Extension)
		: PathWithExtension(PathBase, Extension), IRelativeFilePathExt;

	internal record AbsoluteFilePathExt(string PathBase, FileExtension Extension)
		: PathWithExtension(PathBase, Extension), IAbsoluteFilePathExt;
}
