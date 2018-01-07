// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2018 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// This file is automatically generated.
// Changes to this file will be reverted when you update Steamworks.NET

#if !DISABLESTEAMWORKS

using System.Runtime.InteropServices;
using IntPtr = System.IntPtr;

namespace Steamworks {
	public static class SteamHTMLSurface {
		/// <summary>
		/// <para> Must call init and shutdown when starting/ending use of the interface</para>
		/// </summary>
		public static bool Init() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTMLSurface_Init(CSteamAPIContext.GetSteamHTMLSurface());
		}

		public static bool Shutdown() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamHTMLSurface_Shutdown(CSteamAPIContext.GetSteamHTMLSurface());
		}

		/// <summary>
		/// <para> Create a browser object for display of a html page, when creation is complete the call handle</para>
		/// <para> will return a HTML_BrowserReady_t callback for the HHTMLBrowser of your new browser.</para>
		/// <para>   The user agent string is a substring to be added to the general user agent string so you can</para>
		/// <para> identify your client on web servers.</para>
		/// <para>   The userCSS string lets you apply a CSS style sheet to every displayed page, leave null if</para>
		/// <para> you do not require this functionality.</para>
		/// <para> YOU MUST HAVE IMPLEMENTED HANDLERS FOR HTML_BrowserReady_t, HTML_StartRequest_t,</para>
		/// <para> HTML_JSAlert_t, HTML_JSConfirm_t, and HTML_FileOpenDialog_t! See the CALLBACKS</para>
		/// <para> section of this interface (AllowStartRequest, etc) for more details. If you do</para>
		/// <para> not implement these callback handlers, the browser may appear to hang instead of</para>
		/// <para> navigating to new pages or triggering javascript popups.</para>
		/// </summary>
		public static SteamAPICall_t CreateBrowser(string pchUserAgent, string pchUserCSS) {
			InteropHelp.TestIfAvailableClient();
			using (var pchUserAgent2 = new InteropHelp.UTF8StringHandle(pchUserAgent))
			using (var pchUserCSS2 = new InteropHelp.UTF8StringHandle(pchUserCSS)) {
				return (SteamAPICall_t)NativeMethods.ISteamHTMLSurface_CreateBrowser(CSteamAPIContext.GetSteamHTMLSurface(), pchUserAgent2, pchUserCSS2);
			}
		}

		/// <summary>
		/// <para> Call this when you are done with a html surface, this lets us free the resources being used by it</para>
		/// </summary>
		public static void RemoveBrowser(HHTMLBrowser unBrowserHandle) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_RemoveBrowser(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle);
		}

		/// <summary>
		/// <para> Navigate to this URL, results in a HTML_StartRequest_t as the request commences</para>
		/// </summary>
		public static void LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData) {
			InteropHelp.TestIfAvailableClient();
			using (var pchURL2 = new InteropHelp.UTF8StringHandle(pchURL))
			using (var pchPostData2 = new InteropHelp.UTF8StringHandle(pchPostData)) {
				NativeMethods.ISteamHTMLSurface_LoadURL(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, pchURL2, pchPostData2);
			}
		}

		/// <summary>
		/// <para> Tells the surface the size in pixels to display the surface</para>
		/// </summary>
		public static void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_SetSize(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, unWidth, unHeight);
		}

		/// <summary>
		/// <para> Stop the load of the current html page</para>
		/// </summary>
		public static void StopLoad(HHTMLBrowser unBrowserHandle) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_StopLoad(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle);
		}

		/// <summary>
		/// <para> Reload (most likely from local cache) the current page</para>
		/// </summary>
		public static void Reload(HHTMLBrowser unBrowserHandle) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_Reload(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle);
		}

		/// <summary>
		/// <para> navigate back in the page history</para>
		/// </summary>
		public static void GoBack(HHTMLBrowser unBrowserHandle) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_GoBack(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle);
		}

		/// <summary>
		/// <para> navigate forward in the page history</para>
		/// </summary>
		public static void GoForward(HHTMLBrowser unBrowserHandle) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_GoForward(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle);
		}

		/// <summary>
		/// <para> add this header to any url requests from this browser</para>
		/// </summary>
		public static void AddHeader(HHTMLBrowser unBrowserHandle, string pchKey, string pchValue) {
			InteropHelp.TestIfAvailableClient();
			using (var pchKey2 = new InteropHelp.UTF8StringHandle(pchKey))
			using (var pchValue2 = new InteropHelp.UTF8StringHandle(pchValue)) {
				NativeMethods.ISteamHTMLSurface_AddHeader(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, pchKey2, pchValue2);
			}
		}

		/// <summary>
		/// <para> run this javascript script in the currently loaded page</para>
		/// </summary>
		public static void ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript) {
			InteropHelp.TestIfAvailableClient();
			using (var pchScript2 = new InteropHelp.UTF8StringHandle(pchScript)) {
				NativeMethods.ISteamHTMLSurface_ExecuteJavascript(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, pchScript2);
			}
		}

		/// <summary>
		/// <para> Mouse click and mouse movement commands</para>
		/// </summary>
		public static void MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_MouseUp(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, eMouseButton);
		}

		public static void MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_MouseDown(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, eMouseButton);
		}

		public static void MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_MouseDoubleClick(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, eMouseButton);
		}

		/// <summary>
		/// <para> x and y are relative to the HTML bounds</para>
		/// </summary>
		public static void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_MouseMove(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, x, y);
		}

		/// <summary>
		/// <para> nDelta is pixels of scroll</para>
		/// </summary>
		public static void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_MouseWheel(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, nDelta);
		}

		/// <summary>
		/// <para> keyboard interactions, native keycode is the virtual key code value from your OS</para>
		/// </summary>
		public static void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_KeyDown(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, nNativeKeyCode, eHTMLKeyModifiers);
		}

		public static void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_KeyUp(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, nNativeKeyCode, eHTMLKeyModifiers);
		}

		/// <summary>
		/// <para> cUnicodeChar is the unicode character point for this keypress (and potentially multiple chars per press)</para>
		/// </summary>
		public static void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_KeyChar(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, cUnicodeChar, eHTMLKeyModifiers);
		}

		/// <summary>
		/// <para> programmatically scroll this many pixels on the page</para>
		/// </summary>
		public static void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_SetHorizontalScroll(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, nAbsolutePixelScroll);
		}

		public static void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_SetVerticalScroll(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, nAbsolutePixelScroll);
		}

		/// <summary>
		/// <para> tell the html control if it has key focus currently, controls showing the I-beam cursor in text controls amongst other things</para>
		/// </summary>
		public static void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_SetKeyFocus(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, bHasKeyFocus);
		}

		/// <summary>
		/// <para> open the current pages html code in the local editor of choice, used for debugging</para>
		/// </summary>
		public static void ViewSource(HHTMLBrowser unBrowserHandle) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_ViewSource(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle);
		}

		/// <summary>
		/// <para> copy the currently selected text on the html page to the local clipboard</para>
		/// </summary>
		public static void CopyToClipboard(HHTMLBrowser unBrowserHandle) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_CopyToClipboard(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle);
		}

		/// <summary>
		/// <para> paste from the local clipboard to the current html page</para>
		/// </summary>
		public static void PasteFromClipboard(HHTMLBrowser unBrowserHandle) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_PasteFromClipboard(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle);
		}

		/// <summary>
		/// <para> find this string in the browser, if bCurrentlyInFind is true then instead cycle to the next matching element</para>
		/// </summary>
		public static void Find(HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse) {
			InteropHelp.TestIfAvailableClient();
			using (var pchSearchStr2 = new InteropHelp.UTF8StringHandle(pchSearchStr)) {
				NativeMethods.ISteamHTMLSurface_Find(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, pchSearchStr2, bCurrentlyInFind, bReverse);
			}
		}

		/// <summary>
		/// <para> cancel a currently running find</para>
		/// </summary>
		public static void StopFind(HHTMLBrowser unBrowserHandle) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_StopFind(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle);
		}

		/// <summary>
		/// <para> return details about the link at position x,y on the current page</para>
		/// </summary>
		public static void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_GetLinkAtPosition(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, x, y);
		}

		/// <summary>
		/// <para> set a webcookie for the hostname in question</para>
		/// </summary>
		public static void SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath = "/", uint nExpires = 0, bool bSecure = false, bool bHTTPOnly = false) {
			InteropHelp.TestIfAvailableClient();
			using (var pchHostname2 = new InteropHelp.UTF8StringHandle(pchHostname))
			using (var pchKey2 = new InteropHelp.UTF8StringHandle(pchKey))
			using (var pchValue2 = new InteropHelp.UTF8StringHandle(pchValue))
			using (var pchPath2 = new InteropHelp.UTF8StringHandle(pchPath)) {
				NativeMethods.ISteamHTMLSurface_SetCookie(CSteamAPIContext.GetSteamHTMLSurface(), pchHostname2, pchKey2, pchValue2, pchPath2, nExpires, bSecure, bHTTPOnly);
			}
		}

		/// <summary>
		/// <para> Zoom the current page by flZoom ( from 0.0 to 2.0, so to zoom to 120% use 1.2 ), zooming around point X,Y in the page (use 0,0 if you don't care)</para>
		/// </summary>
		public static void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_SetPageScaleFactor(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, flZoom, nPointX, nPointY);
		}

		/// <summary>
		/// <para> Enable/disable low-resource background mode, where javascript and repaint timers are throttled, resources are</para>
		/// <para> more aggressively purged from memory, and audio/video elements are paused. When background mode is enabled,</para>
		/// <para> all HTML5 video and audio objects will execute ".pause()" and gain the property "._steam_background_paused = 1".</para>
		/// <para> When background mode is disabled, any video or audio objects with that property will resume with ".play()".</para>
		/// </summary>
		public static void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_SetBackgroundMode(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, bBackgroundMode);
		}

		/// <summary>
		/// <para> Scale the output display space by this factor, this is useful when displaying content on high dpi devices.</para>
		/// <para> Specifies the ratio between physical and logical pixels.</para>
		/// </summary>
		public static void SetDPIScalingFactor(HHTMLBrowser unBrowserHandle, float flDPIScaling) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_SetDPIScalingFactor(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, flDPIScaling);
		}

		/// <summary>
		/// <para> CALLBACKS</para>
		/// <para>  These set of functions are used as responses to callback requests</para>
		/// <para> You MUST call this in response to a HTML_StartRequest_t callback</para>
		/// <para>  Set bAllowed to true to allow this navigation, false to cancel it and stay</para>
		/// <para> on the current page. You can use this feature to limit the valid pages</para>
		/// <para> allowed in your HTML surface.</para>
		/// </summary>
		public static void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_AllowStartRequest(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, bAllowed);
		}

		/// <summary>
		/// <para> You MUST call this in response to a HTML_JSAlert_t or HTML_JSConfirm_t callback</para>
		/// <para>  Set bResult to true for the OK option of a confirm, use false otherwise</para>
		/// </summary>
		public static void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_JSDialogResponse(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, bResult);
		}

		/// <summary>
		/// <para> You MUST call this in response to a HTML_FileOpenDialog_t callback</para>
		/// </summary>
		public static void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamHTMLSurface_FileLoadDialogResponse(CSteamAPIContext.GetSteamHTMLSurface(), unBrowserHandle, pchSelectedFiles);
		}
	}
}

#endif // !DISABLESTEAMWORKS
