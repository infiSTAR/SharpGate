using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.OverlaySDK
{
    public class Overlays : Object
    {
        public Overlays(ulong addr) : base(addr) { }
    }
    public class BasicOverlays : Overlays
    {
        public BasicOverlays(ulong addr) : base(addr) { }
        public Array<OverlayItem> Overlays { get { return new Array<OverlayItem>(this[nameof(Overlays)].Address); } }
    }
    public class LocalizedOverlays : Overlays
    {
        public LocalizedOverlays(ulong addr) : base(addr) { }
        public BasicOverlays DefaultOverlays { get { return this[nameof(DefaultOverlays)].As<BasicOverlays>(); } set { this["DefaultOverlays"] = value; } }
        public Object LocaleToOverlaysMap { get { return this[nameof(LocaleToOverlaysMap)]; } set { this[nameof(LocaleToOverlaysMap)] = value; } }
    }
    public class OverlayItem : Object
    {
        public OverlayItem(ulong addr) : base(addr) { }
        public Timespan StartTime { get { return this[nameof(StartTime)].As<Timespan>(); } set { this["StartTime"] = value; } }
        public Timespan EndTime { get { return this[nameof(EndTime)].As<Timespan>(); } set { this["EndTime"] = value; } }
        public Object Text { get { return this[nameof(Text)]; } set { this[nameof(Text)] = value; } }
        public Vector2D Position { get { return this[nameof(Position)].As<Vector2D>(); } set { this["Position"] = value; } }
    }
}
