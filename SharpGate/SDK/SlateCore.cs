using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.SlateCoreSDK
{
    public class FontBulkData : Object
    {
        public FontBulkData(ulong addr) : base(addr) { }
    }
    public class FontFaceInterface : Interface
    {
        public FontFaceInterface(ulong addr) : base(addr) { }
    }
    public class FontProviderInterface : Interface
    {
        public FontProviderInterface(ulong addr) : base(addr) { }
    }
    public class SlateTypes : Object
    {
        public SlateTypes(ulong addr) : base(addr) { }
    }
    public class SlateWidgetStyleAsset : Object
    {
        public SlateWidgetStyleAsset(ulong addr) : base(addr) { }
        public SlateWidgetStyleContainerBase CustomStyle { get { return this[nameof(CustomStyle)].As<SlateWidgetStyleContainerBase>(); } set { this["CustomStyle"] = value; } }
    }
    public class SlateWidgetStyleContainerBase : Object
    {
        public SlateWidgetStyleContainerBase(ulong addr) : base(addr) { }
    }
    public class SlateWidgetStyleContainerInterface : Interface
    {
        public SlateWidgetStyleContainerInterface(ulong addr) : base(addr) { }
    }
    public enum EUINavigation : int
    {
        Left = 0,
        Right = 1,
        Up = 2,
        Down = 3,
        Next = 4,
        Previous = 5,
        Num = 6,
        Invalid = 7,
        EUINavigation_MAX = 8,
    }
    public class Geometry : Object
    {
        public Geometry(ulong addr) : base(addr) { }
    }
    public enum ECheckBoxState : int
    {
        Unchecked = 0,
        Checked = 1,
        Undetermined = 2,
        ECheckBoxState_MAX = 3,
    }
    public enum EWidgetClipping : int
    {
        Inherit = 0,
        ClipToBounds = 1,
        ClipToBoundsWithoutIntersecting = 2,
        ClipToBoundsAlways = 3,
        OnDemand = 4,
        EWidgetClipping_MAX = 5,
    }
    public class SlateBrush : Object
    {
        public SlateBrush(ulong addr) : base(addr) { }
        public Vector2D ImageSize { get { return this[nameof(ImageSize)].As<Vector2D>(); } set { this["ImageSize"] = value; } }
        public Margin Margin { get { return this[nameof(Margin)].As<Margin>(); } set { this["Margin"] = value; } }
        public SlateColor TintColor { get { return this[nameof(TintColor)].As<SlateColor>(); } set { this["TintColor"] = value; } }
        public Object ResourceObject { get { return this[nameof(ResourceObject)].As<Object>(); } set { this["ResourceObject"] = value; } }
        public Object ResourceName { get { return this[nameof(ResourceName)]; } set { this[nameof(ResourceName)] = value; } }
        public Box2D UVRegion { get { return this[nameof(UVRegion)].As<Box2D>(); } set { this["UVRegion"] = value; } }
        public byte DrawAs { get { return this[nameof(DrawAs)].GetValue<byte>(); } set { this[nameof(DrawAs)].SetValue<byte>(value); } }
        public byte Tiling { get { return this[nameof(Tiling)].GetValue<byte>(); } set { this[nameof(Tiling)].SetValue<byte>(value); } }
        public byte Mirroring { get { return this[nameof(Mirroring)].GetValue<byte>(); } set { this[nameof(Mirroring)].SetValue<byte>(value); } }
        public byte ImageType { get { return this[nameof(ImageType)].GetValue<byte>(); } set { this[nameof(ImageType)].SetValue<byte>(value); } }
        public bool bIsDynamicallyLoaded { get { return this[nameof(bIsDynamicallyLoaded)].Flag; } set { this[nameof(bIsDynamicallyLoaded)].Flag = value; } }
        public bool bHasUObject { get { return this[nameof(bHasUObject)].Flag; } set { this[nameof(bHasUObject)].Flag = value; } }
    }
    public enum ESlateBrushImageType : int
    {
        NoImage = 0,
        FullColor = 1,
        Linear = 2,
        ESlateBrushImageType_MAX = 3,
    }
    public enum ESlateBrushMirrorType : int
    {
        NoMirror = 0,
        Horizontal = 1,
        Vertical = 2,
        Both = 3,
        ESlateBrushMirrorType_MAX = 4,
    }
    public enum ESlateBrushTileType : int
    {
        NoTile = 0,
        Horizontal = 1,
        Vertical = 2,
        Both = 3,
        ESlateBrushTileType_MAX = 4,
    }
    public enum ESlateBrushDrawType : int
    {
        NoDrawType = 0,
        Box = 1,
        Border = 2,
        Image = 3,
        ESlateBrushDrawType_MAX = 4,
    }
    public class SlateColor : Object
    {
        public SlateColor(ulong addr) : base(addr) { }
        public LinearColor SpecifiedColor { get { return this[nameof(SpecifiedColor)].As<LinearColor>(); } set { this["SpecifiedColor"] = value; } }
        public byte ColorUseRule { get { return this[nameof(ColorUseRule)].GetValue<byte>(); } set { this[nameof(ColorUseRule)].SetValue<byte>(value); } }
    }
    public enum ESlateColorStylingMode : int
    {
        UseColor_Specified = 0,
        UseColor_Specified_Link = 1,
        UseColor_Foreground = 2,
        UseColor_Foreground_Subdued = 3,
        UseColor_MAX = 4,
    }
    public class Margin : Object
    {
        public Margin(ulong addr) : base(addr) { }
        public float Left { get { return this[nameof(Left)].GetValue<float>(); } set { this[nameof(Left)].SetValue<float>(value); } }
        public float Top { get { return this[nameof(Top)].GetValue<float>(); } set { this[nameof(Top)].SetValue<float>(value); } }
        public float Right { get { return this[nameof(Right)].GetValue<float>(); } set { this[nameof(Right)].SetValue<float>(value); } }
        public float Bottom { get { return this[nameof(Bottom)].GetValue<float>(); } set { this[nameof(Bottom)].SetValue<float>(value); } }
    }
    public class InputEvent : Object
    {
        public InputEvent(ulong addr) : base(addr) { }
    }
    public class PointerEvent : InputEvent
    {
        public PointerEvent(ulong addr) : base(addr) { }
    }
    public enum EUINavigationRule : int
    {
        Escape = 0,
        Explicit = 1,
        Wrap = 2,
        Stop = 3,
        Custom = 4,
        CustomBoundary = 5,
        Invalid = 6,
        EUINavigationRule_MAX = 7,
    }
    public enum EFlowDirectionPreference : int
    {
        Inherit = 0,
        Culture = 1,
        LeftToRight = 2,
        RightToLeft = 3,
        EFlowDirectionPreference_MAX = 4,
    }
    public class CharacterEvent : InputEvent
    {
        public CharacterEvent(ulong addr) : base(addr) { }
    }
    public class KeyEvent : InputEvent
    {
        public KeyEvent(ulong addr) : base(addr) { }
    }
    public class NavigationEvent : InputEvent
    {
        public NavigationEvent(ulong addr) : base(addr) { }
    }
    public class AnalogInputEvent : KeyEvent
    {
        public AnalogInputEvent(ulong addr) : base(addr) { }
    }
    public enum EColorVisionDeficiency : int
    {
        NormalVision = 0,
        Deuteranope = 1,
        Protanope = 2,
        Tritanope = 3,
        EColorVisionDeficiency_MAX = 4,
    }
    public enum ESelectInfo : int
    {
        OnKeyPress = 0,
        OnNavigation = 1,
        OnMouseClick = 2,
        Direct = 3,
        ESelectInfo_MAX = 4,
    }
    public class SlateFontInfo : Object
    {
        public SlateFontInfo(ulong addr) : base(addr) { }
        public Object FontObject { get { return this[nameof(FontObject)].As<Object>(); } set { this["FontObject"] = value; } }
        public Object FontMaterial { get { return this[nameof(FontMaterial)].As<Object>(); } set { this["FontMaterial"] = value; } }
        public FontOutlineSettings OutlineSettings { get { return this[nameof(OutlineSettings)].As<FontOutlineSettings>(); } set { this["OutlineSettings"] = value; } }
        public Object TypefaceFontName { get { return this[nameof(TypefaceFontName)]; } set { this[nameof(TypefaceFontName)] = value; } }
        public int Size { get { return this[nameof(Size)].GetValue<int>(); } set { this[nameof(Size)].SetValue<int>(value); } }
        public int LetterSpacing { get { return this[nameof(LetterSpacing)].GetValue<int>(); } set { this[nameof(LetterSpacing)].SetValue<int>(value); } }
    }
    public class FontOutlineSettings : Object
    {
        public FontOutlineSettings(ulong addr) : base(addr) { }
        public int OutlineSize { get { return this[nameof(OutlineSize)].GetValue<int>(); } set { this[nameof(OutlineSize)].SetValue<int>(value); } }
        public bool bSeparateFillAlpha { get { return this[nameof(bSeparateFillAlpha)].Flag; } set { this[nameof(bSeparateFillAlpha)].Flag = value; } }
        public bool bApplyOutlineToDropShadows { get { return this[nameof(bApplyOutlineToDropShadows)].Flag; } set { this[nameof(bApplyOutlineToDropShadows)].Flag = value; } }
        public Object OutlineMaterial { get { return this[nameof(OutlineMaterial)].As<Object>(); } set { this["OutlineMaterial"] = value; } }
        public LinearColor OutlineColor { get { return this[nameof(OutlineColor)].As<LinearColor>(); } set { this["OutlineColor"] = value; } }
    }
    public class SlateWidgetStyle : Object
    {
        public SlateWidgetStyle(ulong addr) : base(addr) { }
    }
    public class TableRowStyle : SlateWidgetStyle
    {
        public TableRowStyle(ulong addr) : base(addr) { }
        public SlateBrush SelectorFocusedBrush { get { return this[nameof(SelectorFocusedBrush)].As<SlateBrush>(); } set { this["SelectorFocusedBrush"] = value; } }
        public SlateBrush ActiveHoveredBrush { get { return this[nameof(ActiveHoveredBrush)].As<SlateBrush>(); } set { this["ActiveHoveredBrush"] = value; } }
        public SlateBrush ActiveBrush { get { return this[nameof(ActiveBrush)].As<SlateBrush>(); } set { this["ActiveBrush"] = value; } }
        public SlateBrush InactiveHoveredBrush { get { return this[nameof(InactiveHoveredBrush)].As<SlateBrush>(); } set { this["InactiveHoveredBrush"] = value; } }
        public SlateBrush InactiveBrush { get { return this[nameof(InactiveBrush)].As<SlateBrush>(); } set { this["InactiveBrush"] = value; } }
        public SlateBrush EvenRowBackgroundHoveredBrush { get { return this[nameof(EvenRowBackgroundHoveredBrush)].As<SlateBrush>(); } set { this["EvenRowBackgroundHoveredBrush"] = value; } }
        public SlateBrush EvenRowBackgroundBrush { get { return this[nameof(EvenRowBackgroundBrush)].As<SlateBrush>(); } set { this["EvenRowBackgroundBrush"] = value; } }
        public SlateBrush OddRowBackgroundHoveredBrush { get { return this[nameof(OddRowBackgroundHoveredBrush)].As<SlateBrush>(); } set { this["OddRowBackgroundHoveredBrush"] = value; } }
        public SlateBrush OddRowBackgroundBrush { get { return this[nameof(OddRowBackgroundBrush)].As<SlateBrush>(); } set { this["OddRowBackgroundBrush"] = value; } }
        public SlateColor TextColor { get { return this[nameof(TextColor)].As<SlateColor>(); } set { this["TextColor"] = value; } }
        public SlateColor SelectedTextColor { get { return this[nameof(SelectedTextColor)].As<SlateColor>(); } set { this["SelectedTextColor"] = value; } }
        public SlateBrush DropIndicator_Above { get { return this[nameof(DropIndicator_Above)].As<SlateBrush>(); } set { this["DropIndicator_Above"] = value; } }
        public SlateBrush DropIndicator_Onto { get { return this[nameof(DropIndicator_Onto)].As<SlateBrush>(); } set { this["DropIndicator_Onto"] = value; } }
        public SlateBrush DropIndicator_Below { get { return this[nameof(DropIndicator_Below)].As<SlateBrush>(); } set { this["DropIndicator_Below"] = value; } }
        public SlateBrush ActiveHighlightedBrush { get { return this[nameof(ActiveHighlightedBrush)].As<SlateBrush>(); } set { this["ActiveHighlightedBrush"] = value; } }
        public SlateBrush InactiveHighlightedBrush { get { return this[nameof(InactiveHighlightedBrush)].As<SlateBrush>(); } set { this["InactiveHighlightedBrush"] = value; } }
    }
    public class ComboBoxStyle : SlateWidgetStyle
    {
        public ComboBoxStyle(ulong addr) : base(addr) { }
        public ComboButtonStyle ComboButtonStyle { get { return this[nameof(ComboButtonStyle)].As<ComboButtonStyle>(); } set { this["ComboButtonStyle"] = value; } }
        public SlateSound PressedSlateSound { get { return this[nameof(PressedSlateSound)].As<SlateSound>(); } set { this["PressedSlateSound"] = value; } }
        public SlateSound SelectionChangeSlateSound { get { return this[nameof(SelectionChangeSlateSound)].As<SlateSound>(); } set { this["SelectionChangeSlateSound"] = value; } }
    }
    public class SlateSound : Object
    {
        public SlateSound(ulong addr) : base(addr) { }
        public Object ResourceObject { get { return this[nameof(ResourceObject)].As<Object>(); } set { this["ResourceObject"] = value; } }
    }
    public class ComboButtonStyle : SlateWidgetStyle
    {
        public ComboButtonStyle(ulong addr) : base(addr) { }
        public ButtonStyle ButtonStyle { get { return this[nameof(ButtonStyle)].As<ButtonStyle>(); } set { this["ButtonStyle"] = value; } }
        public SlateBrush DownArrowImage { get { return this[nameof(DownArrowImage)].As<SlateBrush>(); } set { this["DownArrowImage"] = value; } }
        public Vector2D ShadowOffset { get { return this[nameof(ShadowOffset)].As<Vector2D>(); } set { this["ShadowOffset"] = value; } }
        public LinearColor ShadowColorAndOpacity { get { return this[nameof(ShadowColorAndOpacity)].As<LinearColor>(); } set { this["ShadowColorAndOpacity"] = value; } }
        public SlateBrush MenuBorderBrush { get { return this[nameof(MenuBorderBrush)].As<SlateBrush>(); } set { this["MenuBorderBrush"] = value; } }
        public Margin MenuBorderPadding { get { return this[nameof(MenuBorderPadding)].As<Margin>(); } set { this["MenuBorderPadding"] = value; } }
    }
    public class ButtonStyle : SlateWidgetStyle
    {
        public ButtonStyle(ulong addr) : base(addr) { }
        public SlateBrush Normal { get { return this[nameof(Normal)].As<SlateBrush>(); } set { this["Normal"] = value; } }
        public SlateBrush Hovered { get { return this[nameof(Hovered)].As<SlateBrush>(); } set { this["Hovered"] = value; } }
        public SlateBrush Pressed { get { return this[nameof(Pressed)].As<SlateBrush>(); } set { this["Pressed"] = value; } }
        public SlateBrush Disabled { get { return this[nameof(Disabled)].As<SlateBrush>(); } set { this["Disabled"] = value; } }
        public Margin NormalPadding { get { return this[nameof(NormalPadding)].As<Margin>(); } set { this["NormalPadding"] = value; } }
        public Margin PressedPadding { get { return this[nameof(PressedPadding)].As<Margin>(); } set { this["PressedPadding"] = value; } }
        public SlateSound PressedSlateSound { get { return this[nameof(PressedSlateSound)].As<SlateSound>(); } set { this["PressedSlateSound"] = value; } }
        public SlateSound HoveredSlateSound { get { return this[nameof(HoveredSlateSound)].As<SlateSound>(); } set { this["HoveredSlateSound"] = value; } }
    }
    public enum ETextCommit : int
    {
        Default = 0,
        OnEnter = 1,
        OnUserMovedFocus = 2,
        OnCleared = 3,
        ETextCommit_MAX = 4,
    }
    public enum ETextShapingMethod : int
    {
        Auto = 0,
        KerningOnly = 1,
        FullShaping = 2,
        ETextShapingMethod_MAX = 3,
    }
    public class EditableTextStyle : SlateWidgetStyle
    {
        public EditableTextStyle(ulong addr) : base(addr) { }
        public SlateFontInfo Font { get { return this[nameof(Font)].As<SlateFontInfo>(); } set { this["Font"] = value; } }
        public SlateColor ColorAndOpacity { get { return this[nameof(ColorAndOpacity)].As<SlateColor>(); } set { this["ColorAndOpacity"] = value; } }
        public SlateBrush BackgroundImageSelected { get { return this[nameof(BackgroundImageSelected)].As<SlateBrush>(); } set { this["BackgroundImageSelected"] = value; } }
        public SlateBrush BackgroundImageComposing { get { return this[nameof(BackgroundImageComposing)].As<SlateBrush>(); } set { this["BackgroundImageComposing"] = value; } }
        public SlateBrush CaretImage { get { return this[nameof(CaretImage)].As<SlateBrush>(); } set { this["CaretImage"] = value; } }
    }
    public class EditableTextBoxStyle : SlateWidgetStyle
    {
        public EditableTextBoxStyle(ulong addr) : base(addr) { }
        public SlateBrush BackgroundImageNormal { get { return this[nameof(BackgroundImageNormal)].As<SlateBrush>(); } set { this["BackgroundImageNormal"] = value; } }
        public SlateBrush BackgroundImageHovered { get { return this[nameof(BackgroundImageHovered)].As<SlateBrush>(); } set { this["BackgroundImageHovered"] = value; } }
        public SlateBrush BackgroundImageFocused { get { return this[nameof(BackgroundImageFocused)].As<SlateBrush>(); } set { this["BackgroundImageFocused"] = value; } }
        public SlateBrush BackgroundImageReadOnly { get { return this[nameof(BackgroundImageReadOnly)].As<SlateBrush>(); } set { this["BackgroundImageReadOnly"] = value; } }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public SlateFontInfo Font { get { return this[nameof(Font)].As<SlateFontInfo>(); } set { this["Font"] = value; } }
        public SlateColor ForegroundColor { get { return this[nameof(ForegroundColor)].As<SlateColor>(); } set { this["ForegroundColor"] = value; } }
        public SlateColor BackgroundColor { get { return this[nameof(BackgroundColor)].As<SlateColor>(); } set { this["BackgroundColor"] = value; } }
        public SlateColor ReadOnlyForegroundColor { get { return this[nameof(ReadOnlyForegroundColor)].As<SlateColor>(); } set { this["ReadOnlyForegroundColor"] = value; } }
        public Margin HScrollBarPadding { get { return this[nameof(HScrollBarPadding)].As<Margin>(); } set { this["HScrollBarPadding"] = value; } }
        public Margin VScrollBarPadding { get { return this[nameof(VScrollBarPadding)].As<Margin>(); } set { this["VScrollBarPadding"] = value; } }
        public ScrollBarStyle ScrollBarStyle { get { return this[nameof(ScrollBarStyle)].As<ScrollBarStyle>(); } set { this["ScrollBarStyle"] = value; } }
    }
    public class ScrollBarStyle : SlateWidgetStyle
    {
        public ScrollBarStyle(ulong addr) : base(addr) { }
        public SlateBrush HorizontalBackgroundImage { get { return this[nameof(HorizontalBackgroundImage)].As<SlateBrush>(); } set { this["HorizontalBackgroundImage"] = value; } }
        public SlateBrush VerticalBackgroundImage { get { return this[nameof(VerticalBackgroundImage)].As<SlateBrush>(); } set { this["VerticalBackgroundImage"] = value; } }
        public SlateBrush VerticalTopSlotImage { get { return this[nameof(VerticalTopSlotImage)].As<SlateBrush>(); } set { this["VerticalTopSlotImage"] = value; } }
        public SlateBrush HorizontalTopSlotImage { get { return this[nameof(HorizontalTopSlotImage)].As<SlateBrush>(); } set { this["HorizontalTopSlotImage"] = value; } }
        public SlateBrush VerticalBottomSlotImage { get { return this[nameof(VerticalBottomSlotImage)].As<SlateBrush>(); } set { this["VerticalBottomSlotImage"] = value; } }
        public SlateBrush HorizontalBottomSlotImage { get { return this[nameof(HorizontalBottomSlotImage)].As<SlateBrush>(); } set { this["HorizontalBottomSlotImage"] = value; } }
        public SlateBrush NormalThumbImage { get { return this[nameof(NormalThumbImage)].As<SlateBrush>(); } set { this["NormalThumbImage"] = value; } }
        public SlateBrush HoveredThumbImage { get { return this[nameof(HoveredThumbImage)].As<SlateBrush>(); } set { this["HoveredThumbImage"] = value; } }
        public SlateBrush DraggedThumbImage { get { return this[nameof(DraggedThumbImage)].As<SlateBrush>(); } set { this["DraggedThumbImage"] = value; } }
    }
    public class TextBlockStyle : SlateWidgetStyle
    {
        public TextBlockStyle(ulong addr) : base(addr) { }
        public SlateFontInfo Font { get { return this[nameof(Font)].As<SlateFontInfo>(); } set { this["Font"] = value; } }
        public SlateColor ColorAndOpacity { get { return this[nameof(ColorAndOpacity)].As<SlateColor>(); } set { this["ColorAndOpacity"] = value; } }
        public Vector2D ShadowOffset { get { return this[nameof(ShadowOffset)].As<Vector2D>(); } set { this["ShadowOffset"] = value; } }
        public LinearColor ShadowColorAndOpacity { get { return this[nameof(ShadowColorAndOpacity)].As<LinearColor>(); } set { this["ShadowColorAndOpacity"] = value; } }
        public SlateColor SelectedBackgroundColor { get { return this[nameof(SelectedBackgroundColor)].As<SlateColor>(); } set { this["SelectedBackgroundColor"] = value; } }
        public LinearColor HighlightColor { get { return this[nameof(HighlightColor)].As<LinearColor>(); } set { this["HighlightColor"] = value; } }
        public SlateBrush HighlightShape { get { return this[nameof(HighlightShape)].As<SlateBrush>(); } set { this["HighlightShape"] = value; } }
        public SlateBrush StrikeBrush { get { return this[nameof(StrikeBrush)].As<SlateBrush>(); } set { this["StrikeBrush"] = value; } }
        public SlateBrush UnderlineBrush { get { return this[nameof(UnderlineBrush)].As<SlateBrush>(); } set { this["UnderlineBrush"] = value; } }
    }
    public enum EMenuPlacement : int
    {
        MenuPlacement_BelowAnchor = 0,
        MenuPlacement_CenteredBelowAnchor = 1,
        MenuPlacement_BelowRightAnchor = 2,
        MenuPlacement_ComboBox = 3,
        MenuPlacement_ComboBoxRight = 4,
        MenuPlacement_MenuRight = 5,
        MenuPlacement_AboveAnchor = 6,
        MenuPlacement_CenteredAboveAnchor = 7,
        MenuPlacement_AboveRightAnchor = 8,
        MenuPlacement_MenuLeft = 9,
        MenuPlacement_Center = 10,
        MenuPlacement_RightLeftCenter = 11,
        MenuPlacement_MatchBottomLeft = 12,
        MenuPlacement_MAX = 13,
    }
    public class SpinBoxStyle : SlateWidgetStyle
    {
        public SpinBoxStyle(ulong addr) : base(addr) { }
        public SlateBrush BackgroundBrush { get { return this[nameof(BackgroundBrush)].As<SlateBrush>(); } set { this["BackgroundBrush"] = value; } }
        public SlateBrush HoveredBackgroundBrush { get { return this[nameof(HoveredBackgroundBrush)].As<SlateBrush>(); } set { this["HoveredBackgroundBrush"] = value; } }
        public SlateBrush ActiveFillBrush { get { return this[nameof(ActiveFillBrush)].As<SlateBrush>(); } set { this["ActiveFillBrush"] = value; } }
        public SlateBrush InactiveFillBrush { get { return this[nameof(InactiveFillBrush)].As<SlateBrush>(); } set { this["InactiveFillBrush"] = value; } }
        public SlateBrush ArrowsImage { get { return this[nameof(ArrowsImage)].As<SlateBrush>(); } set { this["ArrowsImage"] = value; } }
        public SlateColor ForegroundColor { get { return this[nameof(ForegroundColor)].As<SlateColor>(); } set { this["ForegroundColor"] = value; } }
        public Margin TextPadding { get { return this[nameof(TextPadding)].As<Margin>(); } set { this["TextPadding"] = value; } }
    }
    public enum EFontLayoutMethod : int
    {
        Metrics = 0,
        BoundingBox = 1,
        EFontLayoutMethod_MAX = 2,
    }
    public enum EFontLoadingPolicy : int
    {
        LazyLoad = 0,
        Stream = 1,
        Inline = 2,
        EFontLoadingPolicy_MAX = 3,
    }
    public enum EFontHinting : int
    {
        Default = 0,
        Auto = 1,
        AutoLight = 2,
        Monochrome = 3,
        None = 4,
        EFontHinting_MAX = 5,
    }
    public enum EFocusCause : int
    {
        Mouse = 0,
        Navigation = 1,
        SetDirectly = 2,
        Cleared = 3,
        OtherWidgetLostFocus = 4,
        WindowActivate = 5,
        EFocusCause_MAX = 6,
    }
    public enum ESlateDebuggingFocusEvent : int
    {
        FocusChanging = 0,
        FocusLost = 1,
        FocusReceived = 2,
        MAX = 3,
    }
    public enum ESlateDebuggingNavigationMethod : int
    {
        Unknown = 0,
        Explicit = 1,
        CustomDelegateBound = 2,
        CustomDelegateUnbound = 3,
        NextOrPrevious = 4,
        HitTestGrid = 5,
        ESlateDebuggingNavigationMethod_MAX = 6,
    }
    public enum ESlateDebuggingStateChangeEvent : int
    {
        MouseCaptureGained = 0,
        MouseCaptureLost = 1,
        ESlateDebuggingStateChangeEvent_MAX = 2,
    }
    public enum ESlateDebuggingInputEvent : int
    {
        MouseMove = 0,
        MouseEnter = 1,
        MouseLeave = 2,
        PreviewMouseButtonDown = 3,
        MouseButtonDown = 4,
        MouseButtonUp = 5,
        MouseButtonDoubleClick = 6,
        MouseWheel = 7,
        TouchStart = 8,
        TouchEnd = 9,
        TouchForceChanged = 10,
        TouchFirstMove = 11,
        TouchMoved = 12,
        DragDetected = 13,
        DragEnter = 14,
        DragLeave = 15,
        DragOver = 16,
        DragDrop = 17,
        DropMessage = 18,
        PreviewKeyDown = 19,
        KeyDown = 20,
        KeyUp = 21,
        KeyChar = 22,
        AnalogInput = 23,
        TouchGesture = 24,
        MotionDetected = 25,
        MAX = 26,
    }
    public enum EScrollDirection : int
    {
        Scroll_Down = 0,
        Scroll_Up = 1,
        Scroll_MAX = 2,
    }
    public enum EOrientation : int
    {
        Orient_Horizontal = 0,
        Orient_Vertical = 1,
        Orient_MAX = 2,
    }
    public enum EVerticalAlignment : int
    {
        VAlign_Fill = 0,
        VAlign_Top = 1,
        VAlign_Center = 2,
        VAlign_Bottom = 3,
        VAlign_MAX = 4,
    }
    public enum EHorizontalAlignment : int
    {
        HAlign_Fill = 0,
        HAlign_Left = 1,
        HAlign_Center = 2,
        HAlign_Right = 3,
        HAlign_MAX = 4,
    }
    public enum ENavigationGenesis : int
    {
        Keyboard = 0,
        Controller = 1,
        User = 2,
        ENavigationGenesis_MAX = 3,
    }
    public enum ENavigationSource : int
    {
        FocusedWidget = 0,
        WidgetUnderCursor = 1,
        ENavigationSource_MAX = 2,
    }
    public enum EUINavigationAction : int
    {
        Accept = 0,
        Back = 1,
        Num = 2,
        Invalid = 3,
        EUINavigationAction_MAX = 4,
    }
    public enum EButtonPressMethod : int
    {
        DownAndUp = 0,
        ButtonPress = 1,
        ButtonRelease = 2,
        EButtonPressMethod_MAX = 3,
    }
    public enum EButtonTouchMethod : int
    {
        DownAndUp = 0,
        Down = 1,
        PreciseTap = 2,
        EButtonTouchMethod_MAX = 3,
    }
    public enum EButtonClickMethod : int
    {
        DownAndUp = 0,
        MouseDown = 1,
        MouseUp = 2,
        PreciseClick = 3,
        EButtonClickMethod_MAX = 4,
    }
    public enum ESlateCheckBoxType : int
    {
        CheckBox = 0,
        ToggleButton = 1,
        ESlateCheckBoxType_MAX = 2,
    }
    public enum ESlateParentWindowSearchMethod : int
    {
        ActiveWindow = 0,
        MainWindow = 1,
        ESlateParentWindowSearchMethod_MAX = 2,
    }
    public enum EConsumeMouseWheel : int
    {
        WhenScrollingPossible = 0,
        Always = 1,
        Never = 2,
        EConsumeMouseWheel_MAX = 3,
    }
    public class CompositeFont : Object
    {
        public CompositeFont(ulong addr) : base(addr) { }
        public Typeface DefaultTypeface { get { return this[nameof(DefaultTypeface)].As<Typeface>(); } set { this["DefaultTypeface"] = value; } }
        public CompositeFallbackFont FallbackTypeface { get { return this[nameof(FallbackTypeface)].As<CompositeFallbackFont>(); } set { this["FallbackTypeface"] = value; } }
        public Array<CompositeSubFont> SubTypefaces { get { return new Array<CompositeSubFont>(this[nameof(SubTypefaces)].Address); } }
    }
    public class CompositeFallbackFont : Object
    {
        public CompositeFallbackFont(ulong addr) : base(addr) { }
        public Typeface Typeface { get { return this[nameof(Typeface)].As<Typeface>(); } set { this["Typeface"] = value; } }
        public float ScalingFactor { get { return this[nameof(ScalingFactor)].GetValue<float>(); } set { this[nameof(ScalingFactor)].SetValue<float>(value); } }
    }
    public class Typeface : Object
    {
        public Typeface(ulong addr) : base(addr) { }
        public Array<TypefaceEntry> Fonts { get { return new Array<TypefaceEntry>(this[nameof(Fonts)].Address); } }
    }
    public class TypefaceEntry : Object
    {
        public TypefaceEntry(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public FontData Font { get { return this[nameof(Font)].As<FontData>(); } set { this["Font"] = value; } }
    }
    public class FontData : Object
    {
        public FontData(ulong addr) : base(addr) { }
        public Object FontFilename { get { return this[nameof(FontFilename)]; } set { this[nameof(FontFilename)] = value; } }
        public EFontHinting Hinting { get { return (EFontHinting)this[nameof(Hinting)].GetValue<int>(); } set { this[nameof(Hinting)].SetValue<int>((int)value); } }
        public EFontLoadingPolicy LoadingPolicy { get { return (EFontLoadingPolicy)this[nameof(LoadingPolicy)].GetValue<int>(); } set { this[nameof(LoadingPolicy)].SetValue<int>((int)value); } }
        public int SubFaceIndex { get { return this[nameof(SubFaceIndex)].GetValue<int>(); } set { this[nameof(SubFaceIndex)].SetValue<int>(value); } }
        public Object FontFaceAsset { get { return this[nameof(FontFaceAsset)].As<Object>(); } set { this["FontFaceAsset"] = value; } }
    }
    public class CompositeSubFont : CompositeFallbackFont
    {
        public CompositeSubFont(ulong addr) : base(addr) { }
        public Array<Int32Range> CharacterRanges { get { return new Array<Int32Range>(this[nameof(CharacterRanges)].Address); } }
        public Object Cultures { get { return this[nameof(Cultures)]; } set { this[nameof(Cultures)] = value; } }
    }
    public class MotionEvent : InputEvent
    {
        public MotionEvent(ulong addr) : base(addr) { }
    }
    public class CaptureLostEvent : Object
    {
        public CaptureLostEvent(ulong addr) : base(addr) { }
    }
    public class FocusEvent : Object
    {
        public FocusEvent(ulong addr) : base(addr) { }
    }
    public class WindowStyle : SlateWidgetStyle
    {
        public WindowStyle(ulong addr) : base(addr) { }
        public ButtonStyle MinimizeButtonStyle { get { return this[nameof(MinimizeButtonStyle)].As<ButtonStyle>(); } set { this["MinimizeButtonStyle"] = value; } }
        public ButtonStyle MaximizeButtonStyle { get { return this[nameof(MaximizeButtonStyle)].As<ButtonStyle>(); } set { this["MaximizeButtonStyle"] = value; } }
        public ButtonStyle RestoreButtonStyle { get { return this[nameof(RestoreButtonStyle)].As<ButtonStyle>(); } set { this["RestoreButtonStyle"] = value; } }
        public ButtonStyle CloseButtonStyle { get { return this[nameof(CloseButtonStyle)].As<ButtonStyle>(); } set { this["CloseButtonStyle"] = value; } }
        public TextBlockStyle TitleTextStyle { get { return this[nameof(TitleTextStyle)].As<TextBlockStyle>(); } set { this["TitleTextStyle"] = value; } }
        public SlateBrush ActiveTitleBrush { get { return this[nameof(ActiveTitleBrush)].As<SlateBrush>(); } set { this["ActiveTitleBrush"] = value; } }
        public SlateBrush InactiveTitleBrush { get { return this[nameof(InactiveTitleBrush)].As<SlateBrush>(); } set { this["InactiveTitleBrush"] = value; } }
        public SlateBrush FlashTitleBrush { get { return this[nameof(FlashTitleBrush)].As<SlateBrush>(); } set { this["FlashTitleBrush"] = value; } }
        public SlateColor BackgroundColor { get { return this[nameof(BackgroundColor)].As<SlateColor>(); } set { this["BackgroundColor"] = value; } }
        public SlateBrush OutlineBrush { get { return this[nameof(OutlineBrush)].As<SlateBrush>(); } set { this["OutlineBrush"] = value; } }
        public SlateColor OutlineColor { get { return this[nameof(OutlineColor)].As<SlateColor>(); } set { this["OutlineColor"] = value; } }
        public SlateBrush BorderBrush { get { return this[nameof(BorderBrush)].As<SlateBrush>(); } set { this["BorderBrush"] = value; } }
        public SlateBrush BackgroundBrush { get { return this[nameof(BackgroundBrush)].As<SlateBrush>(); } set { this["BackgroundBrush"] = value; } }
        public SlateBrush ChildBackgroundBrush { get { return this[nameof(ChildBackgroundBrush)].As<SlateBrush>(); } set { this["ChildBackgroundBrush"] = value; } }
    }
    public class ScrollBorderStyle : SlateWidgetStyle
    {
        public ScrollBorderStyle(ulong addr) : base(addr) { }
        public SlateBrush TopShadowBrush { get { return this[nameof(TopShadowBrush)].As<SlateBrush>(); } set { this["TopShadowBrush"] = value; } }
        public SlateBrush BottomShadowBrush { get { return this[nameof(BottomShadowBrush)].As<SlateBrush>(); } set { this["BottomShadowBrush"] = value; } }
    }
    public class ScrollBoxStyle : SlateWidgetStyle
    {
        public ScrollBoxStyle(ulong addr) : base(addr) { }
        public SlateBrush TopShadowBrush { get { return this[nameof(TopShadowBrush)].As<SlateBrush>(); } set { this["TopShadowBrush"] = value; } }
        public SlateBrush BottomShadowBrush { get { return this[nameof(BottomShadowBrush)].As<SlateBrush>(); } set { this["BottomShadowBrush"] = value; } }
        public SlateBrush LeftShadowBrush { get { return this[nameof(LeftShadowBrush)].As<SlateBrush>(); } set { this["LeftShadowBrush"] = value; } }
        public SlateBrush RightShadowBrush { get { return this[nameof(RightShadowBrush)].As<SlateBrush>(); } set { this["RightShadowBrush"] = value; } }
    }
    public class DockTabStyle : SlateWidgetStyle
    {
        public DockTabStyle(ulong addr) : base(addr) { }
        public ButtonStyle CloseButtonStyle { get { return this[nameof(CloseButtonStyle)].As<ButtonStyle>(); } set { this["CloseButtonStyle"] = value; } }
        public SlateBrush NormalBrush { get { return this[nameof(NormalBrush)].As<SlateBrush>(); } set { this["NormalBrush"] = value; } }
        public SlateBrush ActiveBrush { get { return this[nameof(ActiveBrush)].As<SlateBrush>(); } set { this["ActiveBrush"] = value; } }
        public SlateBrush ColorOverlayTabBrush { get { return this[nameof(ColorOverlayTabBrush)].As<SlateBrush>(); } set { this["ColorOverlayTabBrush"] = value; } }
        public SlateBrush ColorOverlayIconBrush { get { return this[nameof(ColorOverlayIconBrush)].As<SlateBrush>(); } set { this["ColorOverlayIconBrush"] = value; } }
        public SlateBrush ForegroundBrush { get { return this[nameof(ForegroundBrush)].As<SlateBrush>(); } set { this["ForegroundBrush"] = value; } }
        public SlateBrush HoveredBrush { get { return this[nameof(HoveredBrush)].As<SlateBrush>(); } set { this["HoveredBrush"] = value; } }
        public SlateBrush ContentAreaBrush { get { return this[nameof(ContentAreaBrush)].As<SlateBrush>(); } set { this["ContentAreaBrush"] = value; } }
        public SlateBrush TabWellBrush { get { return this[nameof(TabWellBrush)].As<SlateBrush>(); } set { this["TabWellBrush"] = value; } }
        public Margin TabPadding { get { return this[nameof(TabPadding)].As<Margin>(); } set { this["TabPadding"] = value; } }
        public float OverlapWidth { get { return this[nameof(OverlapWidth)].GetValue<float>(); } set { this[nameof(OverlapWidth)].SetValue<float>(value); } }
        public SlateColor FlashColor { get { return this[nameof(FlashColor)].As<SlateColor>(); } set { this["FlashColor"] = value; } }
    }
    public class HeaderRowStyle : SlateWidgetStyle
    {
        public HeaderRowStyle(ulong addr) : base(addr) { }
        public TableColumnHeaderStyle ColumnStyle { get { return this[nameof(ColumnStyle)].As<TableColumnHeaderStyle>(); } set { this["ColumnStyle"] = value; } }
        public TableColumnHeaderStyle LastColumnStyle { get { return this[nameof(LastColumnStyle)].As<TableColumnHeaderStyle>(); } set { this["LastColumnStyle"] = value; } }
        public SplitterStyle ColumnSplitterStyle { get { return this[nameof(ColumnSplitterStyle)].As<SplitterStyle>(); } set { this["ColumnSplitterStyle"] = value; } }
        public SlateBrush BackgroundBrush { get { return this[nameof(BackgroundBrush)].As<SlateBrush>(); } set { this["BackgroundBrush"] = value; } }
        public SlateColor ForegroundColor { get { return this[nameof(ForegroundColor)].As<SlateColor>(); } set { this["ForegroundColor"] = value; } }
    }
    public class SplitterStyle : SlateWidgetStyle
    {
        public SplitterStyle(ulong addr) : base(addr) { }
        public SlateBrush HandleNormalBrush { get { return this[nameof(HandleNormalBrush)].As<SlateBrush>(); } set { this["HandleNormalBrush"] = value; } }
        public SlateBrush HandleHighlightBrush { get { return this[nameof(HandleHighlightBrush)].As<SlateBrush>(); } set { this["HandleHighlightBrush"] = value; } }
    }
    public class TableColumnHeaderStyle : SlateWidgetStyle
    {
        public TableColumnHeaderStyle(ulong addr) : base(addr) { }
        public SlateBrush SortPrimaryAscendingImage { get { return this[nameof(SortPrimaryAscendingImage)].As<SlateBrush>(); } set { this["SortPrimaryAscendingImage"] = value; } }
        public SlateBrush SortPrimaryDescendingImage { get { return this[nameof(SortPrimaryDescendingImage)].As<SlateBrush>(); } set { this["SortPrimaryDescendingImage"] = value; } }
        public SlateBrush SortSecondaryAscendingImage { get { return this[nameof(SortSecondaryAscendingImage)].As<SlateBrush>(); } set { this["SortSecondaryAscendingImage"] = value; } }
        public SlateBrush SortSecondaryDescendingImage { get { return this[nameof(SortSecondaryDescendingImage)].As<SlateBrush>(); } set { this["SortSecondaryDescendingImage"] = value; } }
        public SlateBrush NormalBrush { get { return this[nameof(NormalBrush)].As<SlateBrush>(); } set { this["NormalBrush"] = value; } }
        public SlateBrush HoveredBrush { get { return this[nameof(HoveredBrush)].As<SlateBrush>(); } set { this["HoveredBrush"] = value; } }
        public SlateBrush MenuDropdownImage { get { return this[nameof(MenuDropdownImage)].As<SlateBrush>(); } set { this["MenuDropdownImage"] = value; } }
        public SlateBrush MenuDropdownNormalBorderBrush { get { return this[nameof(MenuDropdownNormalBorderBrush)].As<SlateBrush>(); } set { this["MenuDropdownNormalBorderBrush"] = value; } }
        public SlateBrush MenuDropdownHoveredBorderBrush { get { return this[nameof(MenuDropdownHoveredBorderBrush)].As<SlateBrush>(); } set { this["MenuDropdownHoveredBorderBrush"] = value; } }
    }
    public class InlineTextImageStyle : SlateWidgetStyle
    {
        public InlineTextImageStyle(ulong addr) : base(addr) { }
        public SlateBrush Image { get { return this[nameof(Image)].As<SlateBrush>(); } set { this["Image"] = value; } }
        public short Baseline { get { return this[nameof(Baseline)].GetValue<short>(); } set { this[nameof(Baseline)].SetValue<short>(value); } }
    }
    public class VolumeControlStyle : SlateWidgetStyle
    {
        public VolumeControlStyle(ulong addr) : base(addr) { }
        public SliderStyle SliderStyle { get { return this[nameof(SliderStyle)].As<SliderStyle>(); } set { this["SliderStyle"] = value; } }
        public SlateBrush HighVolumeImage { get { return this[nameof(HighVolumeImage)].As<SlateBrush>(); } set { this["HighVolumeImage"] = value; } }
        public SlateBrush MidVolumeImage { get { return this[nameof(MidVolumeImage)].As<SlateBrush>(); } set { this["MidVolumeImage"] = value; } }
        public SlateBrush LowVolumeImage { get { return this[nameof(LowVolumeImage)].As<SlateBrush>(); } set { this["LowVolumeImage"] = value; } }
        public SlateBrush NoVolumeImage { get { return this[nameof(NoVolumeImage)].As<SlateBrush>(); } set { this["NoVolumeImage"] = value; } }
        public SlateBrush MutedImage { get { return this[nameof(MutedImage)].As<SlateBrush>(); } set { this["MutedImage"] = value; } }
    }
    public class SliderStyle : SlateWidgetStyle
    {
        public SliderStyle(ulong addr) : base(addr) { }
        public SlateBrush NormalBarImage { get { return this[nameof(NormalBarImage)].As<SlateBrush>(); } set { this["NormalBarImage"] = value; } }
        public SlateBrush HoveredBarImage { get { return this[nameof(HoveredBarImage)].As<SlateBrush>(); } set { this["HoveredBarImage"] = value; } }
        public SlateBrush DisabledBarImage { get { return this[nameof(DisabledBarImage)].As<SlateBrush>(); } set { this["DisabledBarImage"] = value; } }
        public SlateBrush NormalThumbImage { get { return this[nameof(NormalThumbImage)].As<SlateBrush>(); } set { this["NormalThumbImage"] = value; } }
        public SlateBrush HoveredThumbImage { get { return this[nameof(HoveredThumbImage)].As<SlateBrush>(); } set { this["HoveredThumbImage"] = value; } }
        public SlateBrush DisabledThumbImage { get { return this[nameof(DisabledThumbImage)].As<SlateBrush>(); } set { this["DisabledThumbImage"] = value; } }
        public float BarThickness { get { return this[nameof(BarThickness)].GetValue<float>(); } set { this[nameof(BarThickness)].SetValue<float>(value); } }
    }
    public class SearchBoxStyle : SlateWidgetStyle
    {
        public SearchBoxStyle(ulong addr) : base(addr) { }
        public EditableTextBoxStyle TextBoxStyle { get { return this[nameof(TextBoxStyle)].As<EditableTextBoxStyle>(); } set { this["TextBoxStyle"] = value; } }
        public SlateFontInfo ActiveFontInfo { get { return this[nameof(ActiveFontInfo)].As<SlateFontInfo>(); } set { this["ActiveFontInfo"] = value; } }
        public SlateBrush UpArrowImage { get { return this[nameof(UpArrowImage)].As<SlateBrush>(); } set { this["UpArrowImage"] = value; } }
        public SlateBrush DownArrowImage { get { return this[nameof(DownArrowImage)].As<SlateBrush>(); } set { this["DownArrowImage"] = value; } }
        public SlateBrush GlassImage { get { return this[nameof(GlassImage)].As<SlateBrush>(); } set { this["GlassImage"] = value; } }
        public SlateBrush ClearImage { get { return this[nameof(ClearImage)].As<SlateBrush>(); } set { this["ClearImage"] = value; } }
        public Margin ImagePadding { get { return this[nameof(ImagePadding)].As<Margin>(); } set { this["ImagePadding"] = value; } }
        public bool bLeftAlignButtons { get { return this[nameof(bLeftAlignButtons)].Flag; } set { this[nameof(bLeftAlignButtons)].Flag = value; } }
    }
    public class ExpandableAreaStyle : SlateWidgetStyle
    {
        public ExpandableAreaStyle(ulong addr) : base(addr) { }
        public SlateBrush CollapsedImage { get { return this[nameof(CollapsedImage)].As<SlateBrush>(); } set { this["CollapsedImage"] = value; } }
        public SlateBrush ExpandedImage { get { return this[nameof(ExpandedImage)].As<SlateBrush>(); } set { this["ExpandedImage"] = value; } }
        public float RolloutAnimationSeconds { get { return this[nameof(RolloutAnimationSeconds)].GetValue<float>(); } set { this[nameof(RolloutAnimationSeconds)].SetValue<float>(value); } }
    }
    public class ProgressBarStyle : SlateWidgetStyle
    {
        public ProgressBarStyle(ulong addr) : base(addr) { }
        public SlateBrush BackgroundImage { get { return this[nameof(BackgroundImage)].As<SlateBrush>(); } set { this["BackgroundImage"] = value; } }
        public SlateBrush FillImage { get { return this[nameof(FillImage)].As<SlateBrush>(); } set { this["FillImage"] = value; } }
        public SlateBrush MarqueeImage { get { return this[nameof(MarqueeImage)].As<SlateBrush>(); } set { this["MarqueeImage"] = value; } }
    }
    public class InlineEditableTextBlockStyle : SlateWidgetStyle
    {
        public InlineEditableTextBlockStyle(ulong addr) : base(addr) { }
        public EditableTextBoxStyle EditableTextBoxStyle { get { return this[nameof(EditableTextBoxStyle)].As<EditableTextBoxStyle>(); } set { this["EditableTextBoxStyle"] = value; } }
        public TextBlockStyle TextStyle { get { return this[nameof(TextStyle)].As<TextBlockStyle>(); } set { this["TextStyle"] = value; } }
    }
    public class HyperlinkStyle : SlateWidgetStyle
    {
        public HyperlinkStyle(ulong addr) : base(addr) { }
        public ButtonStyle UnderlineStyle { get { return this[nameof(UnderlineStyle)].As<ButtonStyle>(); } set { this["UnderlineStyle"] = value; } }
        public TextBlockStyle TextStyle { get { return this[nameof(TextStyle)].As<TextBlockStyle>(); } set { this["TextStyle"] = value; } }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
    }
    public class CheckBoxStyle : SlateWidgetStyle
    {
        public CheckBoxStyle(ulong addr) : base(addr) { }
        public byte CheckBoxType { get { return this[nameof(CheckBoxType)].GetValue<byte>(); } set { this[nameof(CheckBoxType)].SetValue<byte>(value); } }
        public SlateBrush UncheckedImage { get { return this[nameof(UncheckedImage)].As<SlateBrush>(); } set { this["UncheckedImage"] = value; } }
        public SlateBrush UncheckedHoveredImage { get { return this[nameof(UncheckedHoveredImage)].As<SlateBrush>(); } set { this["UncheckedHoveredImage"] = value; } }
        public SlateBrush UncheckedPressedImage { get { return this[nameof(UncheckedPressedImage)].As<SlateBrush>(); } set { this["UncheckedPressedImage"] = value; } }
        public SlateBrush CheckedImage { get { return this[nameof(CheckedImage)].As<SlateBrush>(); } set { this["CheckedImage"] = value; } }
        public SlateBrush CheckedHoveredImage { get { return this[nameof(CheckedHoveredImage)].As<SlateBrush>(); } set { this["CheckedHoveredImage"] = value; } }
        public SlateBrush CheckedPressedImage { get { return this[nameof(CheckedPressedImage)].As<SlateBrush>(); } set { this["CheckedPressedImage"] = value; } }
        public SlateBrush UndeterminedImage { get { return this[nameof(UndeterminedImage)].As<SlateBrush>(); } set { this["UndeterminedImage"] = value; } }
        public SlateBrush UndeterminedHoveredImage { get { return this[nameof(UndeterminedHoveredImage)].As<SlateBrush>(); } set { this["UndeterminedHoveredImage"] = value; } }
        public SlateBrush UndeterminedPressedImage { get { return this[nameof(UndeterminedPressedImage)].As<SlateBrush>(); } set { this["UndeterminedPressedImage"] = value; } }
        public Margin Padding { get { return this[nameof(Padding)].As<Margin>(); } set { this["Padding"] = value; } }
        public SlateColor ForegroundColor { get { return this[nameof(ForegroundColor)].As<SlateColor>(); } set { this["ForegroundColor"] = value; } }
        public SlateColor BorderBackgroundColor { get { return this[nameof(BorderBackgroundColor)].As<SlateColor>(); } set { this["BorderBackgroundColor"] = value; } }
        public SlateSound CheckedSlateSound { get { return this[nameof(CheckedSlateSound)].As<SlateSound>(); } set { this["CheckedSlateSound"] = value; } }
        public SlateSound UncheckedSlateSound { get { return this[nameof(UncheckedSlateSound)].As<SlateSound>(); } set { this["UncheckedSlateSound"] = value; } }
        public SlateSound HoveredSlateSound { get { return this[nameof(HoveredSlateSound)].As<SlateSound>(); } set { this["HoveredSlateSound"] = value; } }
    }
}
