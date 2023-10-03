# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [2.1.13] - 2020-07-23
### Changed
- Added EULA change notification to the Getting Started window popup.
- `Sirenix.Utilities.PropertyInfoExtensions.IsAutoProperty` now takes an optional parameter specifying whether it should allow virtual properties to be considered auto properties.
- The default SerializationPolicy (`SerializationPolicies.Unity`) now allows serialization of properties that are not virtual, and also properties that are not auto-properties. The only constraint for serializing a property is now that it has both a getter and a setter, regardless of accessibility. We still encourage people to not serialize properties, but this limitation was entirely artificial and in the end, we've chosen to remove it so people can make their own decisions in the matter.
### Fixed
- _Mac users rejoice!_ After a long time with little progress, we have finally fixed a long-standing issue that has plagued Mac users since the original 1.0 release of Odin: list drag-and-dropping should now always work smoothly and as intended on Mac. It turned out that a difference in the behaviours between Unity's Undo system on Mac and Windows was causing the list changes to be reverted by said Undo system. This has now been fixed on Mac, in a way such that Undo still works. This fixes issue [#266](https://bitbucket.org/sirenix/odin-inspector/issues/266/reorder-dragndrop-being-discarded-on-macos).
- Improved and fixed grammar and spelling in the serialization debugger's messages and reasoning about member serialization.
- Applying the `[LabelText]` attribute to enum members now also changes the displayed value string of the enum, instead of only affecting the names of the value entries in the enum selector popup.
- Delegates returned by `TypeExtensions.GetEqualityComparerDelegate<T>()` now consider `float.NaN` and `double.NaN` to be equal to themselves. This is different from the language convention, but more useful and correct for the purposes these returned delegates serve. This fixes issues [#661](https://bitbucket.org/sirenix/odin-inspector/issues/661/odin-inspector-cant-update-nan-double) and [#662](https://bitbucket.org/sirenix/odin-inspector/issues/662/double-field-with-onvaluechanged-causes).
- Fixed an issue where no foldout control would be drawn on `TableList` toolbars when the `TableList` had no label.
- `InspectorProperty.RecordForUndo` will now correctly **_not_** record for Undo if `PropertyTree.WillUndo` is false.
- Odin's EnumSelector now also supports Unity's 2019.2+ `[InspectorName]` attribute for renaming individual enum values in the inspector. This has the exact same effect as using Odin's `[LabelText]` on enum members.
- Fixed some serious thread safety issues in Odin deserialization of Unity objects. This fixes async loading of addressables and other assets, and should fix a multitude of other mysterious, hard-to-reproduce issues that people have seen over the years with Unity object deserialization.
- Changed the `ICache<out T>` interface to a weakly typed `ICache`, because older Unity runtimes crash the moment they encounter generic covariance.
- Fixed sbyte's that were less than 0 always being deserialized as 0 by the binary data format.
- Added extra try-catch guards around handling of loaded assembly such that broken/corrupt assemblies should be properly passed over/ignored during registration of type name rebinding attributes (`BindTypeNameToTypeAttribute`) in the `DefaultSerializationBinder` type.
- Fixed rare case where `DefaultSerializationBinder` would cause an assembly loading deadlock deep in the Mono runtime, in projects with very specific assembly dependency setups.
- The build validation hook will now throw a `BuildFailedException` instead of a regular `Exception`, when it is trying to stop the current build from finishing.

## [1.0.0] - 2017-05-12
### Added
- First release
