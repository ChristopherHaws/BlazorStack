# BlazorStack
[![Build Status][ci-badge]][ci]
[![NuGet][nuget-badge] ![NuGet Downloads][nuget-download-badge]][nuget]
[![FuGet][fuget-badge]][fuget]

[ci]: https://github.com/ChristopherHaws/BlazorStack/actions?query=workflow%3ACI+branch%3Amain
[ci-badge]: https://github.com/ChristopherHaws/BlazorStack/workflows/CI/badge.svg

[nuget]: https://www.nuget.org/packages/BlazorStack/
[nuget-badge]: https://img.shields.io/nuget/v/BlazorStack.svg?style=flat-square
[nuget-download-badge]: https://img.shields.io/nuget/dt/BlazorStack?style=flat-square

[fuget]: https://www.fuget.org/packages/BlazorStack
[fuget-badge]: https://www.fuget.org/packages/BlazorStack/badge.svg

A stack/flexbox implementation for Blazor based on [React FluentUI's Stack](https://developer.microsoft.com/en-us/fluentui#/controls/web/stack) component which itself is based on [WPF's StackPanel](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.stackpanel?view=windowsdesktop-6.0).

**Demo Site**: https://blazorstack.dev/

## Install
BlazorStack relies on [BlazorStyled](https://blazorstyled.io) to render dynamic styles. Please follow the [install instructions](https://blazorstyled.io/install) for that library when using BlazorStack.

##### Client Side `Program.cs`

```csharp
builder.Services.AddBlazorStyled();
```

##### Server Side `Startup.cs`
```csharp
services.AddBlazorStyled();
```

##### Server and Client Side `_Imports.razor`
```razor
@using BlazorStack
```

## Usage
```html
<Stack
    Horizontal
    Wrap
    HorizontalAlignment="Alignment.Start"
    VerticalAlignment="Alignment.Start"
    HorizontalGap="10"
    VerticalGap="20"
>
@for(var i = 0; i < 10; i++) {
    <div>@i</div>
}
</Stack>
```

#### Options
- `Horizontal` Defines whether to render Stack children horizontally.
- `Wrap` Defines whether Stack children should wrap onto multiple rows or columns when they are about to overflow the size of the Stack.
- `HorizontalAlignment` Defines how to align Stack children horizontally (along the x-axis).
- `VerticalAlignment` Defines how to align Stack children horizontally (along the y-axis).
- `HorizontalGap` Defines the column spacing between Stack children.
- `VerticalGap` Defines the row spacing between Stack children.
- `Gap` Defines the spacing between Stack children.
- `MaxHeight` Defines the maximum height that the Stack can take.
- `MaxWidth` Defines the maximum width that the Stack can take.
- `MinHeight` Defines the minimum height that the Stack can take.
- `MinWidth` Defines the minimum width that the Stack can take.
- `Reverse` Defines whether to render Stack children in the opposite direction (bottom-to-top if it's a vertical Stack and right-to-left if it's a horizontal Stack).
- `VerticalFill` Defines whether the Stack should take up 100% of the height of its parent.
