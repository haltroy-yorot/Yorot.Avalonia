using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefNet;
using CefNet.Internal;
using CefNet.Net;

namespace Yorot_Avalonia.Handlers
{
    internal class YorotSchemeHandlerFactory : CefSchemeHandlerFactory
    {
        protected override CefResourceHandler Create(CefBrowser browser, CefFrame frame, string schemeName, CefRequest request)
        {
            return base.Create(browser, frame, schemeName, request);
        }
    }

    internal class YorotGlue : WebViewGlue
    {
        private Views.TabWindow tabWindow;

        public YorotGlue(Views.TabWindow _tabwindow, IChromiumWebViewPrivate view) : base(view)
        {
            tabWindow = _tabwindow;
        }

        protected override bool CanDownload(CefBrowser browser, string url, string requestMethod)
        {
            return base.CanDownload(browser, url, requestMethod);
        }

        protected override bool CanSaveCookie(CefBrowser browser, CefFrame frame, CefRequest request, CefResponse response, CefCookie cookie)
        {
            return base.CanSaveCookie(browser, frame, request, response, cookie);
        }

        protected override bool CanSendCookie(CefBrowser browser, CefFrame frame, CefRequest request, CefCookie cookie)
        {
            return base.CanSendCookie(browser, frame, request, cookie);
        }

        protected override bool DoClose(CefBrowser browser)
        {
            return base.DoClose(browser);
        }

        protected override bool GetAudioParameters(CefBrowser browser, ref CefAudioParameters @params)
        {
            return base.GetAudioParameters(browser, ref @params);
        }

        protected override bool GetAuthCredentials(CefBrowser browser, string originUrl, bool isProxy, string host, int port, string realm, string scheme, CefAuthCallback callback)
        {
            return base.GetAuthCredentials(browser, originUrl, isProxy, host, port, realm, scheme, callback);
        }

        protected override CefCookieAccessFilter GetCookieAccessFilter(CefBrowser browser, CefFrame frame, CefRequest request)
        {
            return base.GetCookieAccessFilter(browser, frame, request);
        }

        protected override CefSize GetPdfPaperSize(CefBrowser browser, int deviceUnitsPerInch)
        {
            return base.GetPdfPaperSize(browser, deviceUnitsPerInch);
        }

        protected override CefResourceHandler GetResourceHandler(CefBrowser browser, CefFrame frame, CefRequest request)
        {
            if (request.Url.ToLowerInvariant().StartsWith("yorot://"))
            {
                var
                return new StringSource(source, type);
            }
            return base.GetResourceHandler(browser, frame, request);
        }

        protected override CefResourceRequestHandler GetResourceRequestHandler(CefBrowser browser, CefFrame frame, CefRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref int disableDefaultHandling)
        {
            return base.GetResourceRequestHandler(browser, frame, request, isNavigation, isDownload, requestInitiator, ref disableDefaultHandling);
        }

        protected override CefResponseFilter GetResourceResponseFilter(CefBrowser browser, CefFrame frame, CefRequest request, CefResponse response)
        {
            return base.GetResourceResponseFilter(browser, frame, request, response);
        }

        protected override bool GetRootScreenRect(CefBrowser browser, ref CefRect rect)
        {
            return base.GetRootScreenRect(browser, ref rect);
        }

        protected override bool GetScreenInfo(CefBrowser browser, ref CefScreenInfo screenInfo)
        {
            return base.GetScreenInfo(browser, ref screenInfo);
        }

        protected override bool GetScreenPoint(CefBrowser browser, int viewX, int viewY, ref int screenX, ref int screenY)
        {
            return base.GetScreenPoint(browser, viewX, viewY, ref screenX, ref screenY);
        }

        protected override void GetViewRect(CefBrowser browser, ref CefRect rect)
        {
            base.GetViewRect(browser, ref rect);
        }

        protected override void OnAcceleratedPaint(CefBrowser browser, CefPaintElementType type, CefRect[] dirtyRects, IntPtr sharedHandle)
        {
            base.OnAcceleratedPaint(browser, type, dirtyRects, sharedHandle);
        }

        protected override void OnAddressChange(CefBrowser browser, CefFrame frame, string url)
        {
            base.OnAddressChange(browser, frame, url);
        }

        protected override void OnAfterCreated(CefBrowser browser)
        {
            base.OnAfterCreated(browser);
        }

        protected override void OnAudioStreamError(CefBrowser browser, string message)
        {
            base.OnAudioStreamError(browser, message);
        }

        protected override void OnAudioStreamPacket(CefBrowser browser, IntPtr data, int frames, long pts)
        {
            base.OnAudioStreamPacket(browser, data, frames, pts);
        }

        protected override void OnAudioStreamStarted(CefBrowser browser, CefAudioParameters @params, int channels)
        {
            base.OnAudioStreamStarted(browser, @params, channels);
        }

        protected override void OnAudioStreamStopped(CefBrowser browser)
        {
            base.OnAudioStreamStopped(browser);
        }

        protected override bool OnAutoResize(CefBrowser browser, CefSize newSize)
        {
            return base.OnAutoResize(browser, newSize);
        }

        protected override bool OnBeforeBrowse(CefBrowser browser, CefFrame frame, CefRequest request, bool userGesture, bool isRedirect)
        {
            return base.OnBeforeBrowse(browser, frame, request, userGesture, isRedirect);
        }

        protected override void OnBeforeClose(CefBrowser browser)
        {
            base.OnBeforeClose(browser);
        }

        protected override void OnBeforeContextMenu(CefBrowser browser, CefFrame frame, CefContextMenuParams menuParams, CefMenuModel model)
        {
            base.OnBeforeContextMenu(browser, frame, menuParams, model);
        }

        protected override void OnBeforeDownload(CefBrowser browser, CefDownloadItem downloadItem, string suggestedName, CefBeforeDownloadCallback callback)
        {
            base.OnBeforeDownload(browser, downloadItem, suggestedName, callback);
        }

        protected override bool OnBeforePopup(CefBrowser browser, CefFrame frame, string targetUrl, string targetFrameName, CefWindowOpenDisposition targetDisposition, bool userGesture, CefPopupFeatures popupFeatures, CefWindowInfo windowInfo, ref CefClient client, CefBrowserSettings settings, ref CefDictionaryValue extraInfo, ref int noJavascriptAccess)
        {
            return base.OnBeforePopup(browser, frame, targetUrl, targetFrameName, targetDisposition, userGesture, popupFeatures, windowInfo, ref client, settings, ref extraInfo, ref noJavascriptAccess);
        }

        protected override CefReturnValue OnBeforeResourceLoad(CefBrowser browser, CefFrame frame, CefRequest request, CefCallback callback)
        {
            return base.OnBeforeResourceLoad(browser, frame, request, callback);
        }

        protected override bool OnBeforeUnloadDialog(CefBrowser browser, string messageText, bool isReload, CefJSDialogCallback callback)
        {
            return base.OnBeforeUnloadDialog(browser, messageText, isReload, callback);
        }

        protected override bool OnCertificateError(CefBrowser browser, CefErrorCode certError, string requestUrl, CefSSLInfo sslInfo, CefCallback callback)
        {
            return base.OnCertificateError(browser, certError, requestUrl, sslInfo, callback);
        }

        protected override bool OnChromeCommand(CefBrowser browser, int commandId, CefWindowOpenDisposition disposition)
        {
            return base.OnChromeCommand(browser, commandId, disposition);
        }

        protected override bool OnConsoleMessage(CefBrowser browser, CefLogSeverity level, string message, string source, int line)
        {
            return base.OnConsoleMessage(browser, level, message, source, line);
        }

        protected override bool OnContextMenuCommand(CefBrowser browser, CefFrame frame, CefContextMenuParams menuParams, int commandId, CefEventFlags eventFlags)
        {
            return base.OnContextMenuCommand(browser, frame, menuParams, commandId, eventFlags);
        }

        protected override void OnContextMenuDismissed(CefBrowser browser, CefFrame frame)
        {
            base.OnContextMenuDismissed(browser, frame);
        }

        protected override bool OnCursorChange(CefBrowser browser, IntPtr cursor, CefCursorType type, CefCursorInfo customCursorInfo)
        {
            return base.OnCursorChange(browser, cursor, type, customCursorInfo);
        }

        protected override void OnDialogClosed(CefBrowser browser)
        {
            base.OnDialogClosed(browser);
        }

        protected override void OnDocumentAvailableInMainFrame(CefBrowser browser)
        {
            base.OnDocumentAvailableInMainFrame(browser);
        }

        protected override void OnDownloadUpdated(CefBrowser browser, CefDownloadItem downloadItem, CefDownloadItemCallback callback)
        {
            base.OnDownloadUpdated(browser, downloadItem, callback);
        }

        protected override bool OnDragEnter(CefBrowser browser, CefDragData dragData, CefDragOperationsMask mask)
        {
            return base.OnDragEnter(browser, dragData, mask);
        }

        protected override void OnDraggableRegionsChanged(CefBrowser browser, CefFrame frame, CefDraggableRegion[] regions)
        {
            base.OnDraggableRegionsChanged(browser, frame, regions);
        }

        protected override void OnFaviconUrlChange(CefBrowser browser, CefStringList iconUrls)
        {
            base.OnFaviconUrlChange(browser, iconUrls);
        }

        protected override bool OnFileDialog(CefBrowser browser, CefFileDialogMode mode, string title, string defaultFilePath, CefStringList acceptFilters, CefFileDialogCallback callback)
        {
            return base.OnFileDialog(browser, mode, title, defaultFilePath, acceptFilters, callback);
        }

        protected override void OnFindResult(CefBrowser browser, int identifier, int count, CefRect selectionRect, int activeMatchOrdinal, bool finalUpdate)
        {
            base.OnFindResult(browser, identifier, count, selectionRect, activeMatchOrdinal, finalUpdate);
        }

        protected override void OnFrameAttached(CefBrowser browser, CefFrame frame, bool reattached)
        {
            base.OnFrameAttached(browser, frame, reattached);
        }

        protected override void OnFrameCreated(CefBrowser browser, CefFrame frame)
        {
            base.OnFrameCreated(browser, frame);
        }

        protected override void OnFrameDetached(CefBrowser browser, CefFrame frame)
        {
            base.OnFrameDetached(browser, frame);
        }

        protected override void OnFullscreenModeChange(CefBrowser browser, bool fullscreen)
        {
            base.OnFullscreenModeChange(browser, fullscreen);
        }

        protected override void OnGotFocus(CefBrowser browser)
        {
            base.OnGotFocus(browser);
        }

        protected override void OnImeCompositionRangeChanged(CefBrowser browser, CefRange selectedRange, CefRect[] characterBounds)
        {
            base.OnImeCompositionRangeChanged(browser, selectedRange, characterBounds);
        }

        protected override bool OnJSDialog(CefBrowser browser, string originUrl, CefJSDialogType dialogType, string messageText, string defaultPromptText, CefJSDialogCallback callback, ref int suppressMessage)
        {
            return base.OnJSDialog(browser, originUrl, dialogType, messageText, defaultPromptText, callback, ref suppressMessage);
        }

        protected override bool OnKeyEvent(CefBrowser browser, CefKeyEvent @event, CefEventHandle osEvent)
        {
            return base.OnKeyEvent(browser, @event, osEvent);
        }

        protected override void OnLoadEnd(CefBrowser browser, CefFrame frame, int httpStatusCode)
        {
            base.OnLoadEnd(browser, frame, httpStatusCode);
        }

        protected override void OnLoadError(CefBrowser browser, CefFrame frame, CefErrorCode errorCode, string errorText, string failedUrl)
        {
            base.OnLoadError(browser, frame, errorCode, errorText, failedUrl);
        }

        protected override void OnLoadingProgressChange(CefBrowser browser, double progress)
        {
            base.OnLoadingProgressChange(browser, progress);
        }

        protected override void OnLoadingStateChange(CefBrowser browser, bool isLoading, bool canGoBack, bool canGoForward)
        {
            base.OnLoadingStateChange(browser, isLoading, canGoBack, canGoForward);
        }

        protected override void OnLoadStart(CefBrowser browser, CefFrame frame, CefTransitionType transitionType)
        {
            base.OnLoadStart(browser, frame, transitionType);
        }

        protected override void OnMainFrameChanged(CefBrowser browser, CefFrame oldFrame, CefFrame newFrame)
        {
            base.OnMainFrameChanged(browser, oldFrame, newFrame);
        }

        protected override bool OnOpenUrlFromTab(CefBrowser browser, CefFrame frame, string targetUrl, CefWindowOpenDisposition targetDisposition, bool userGesture)
        {
            return base.OnOpenUrlFromTab(browser, frame, targetUrl, targetDisposition, userGesture);
        }

        protected override void OnPaint(CefBrowser browser, CefPaintElementType type, CefRect[] dirtyRects, IntPtr buffer, int width, int height)
        {
            base.OnPaint(browser, type, dirtyRects, buffer, width, height);
        }

        protected override void OnPdfPrintFinished(string path, bool success)
        {
            base.OnPdfPrintFinished(path, success);
        }

        protected override void OnPluginCrashed(CefBrowser browser, string pluginPath)
        {
            base.OnPluginCrashed(browser, pluginPath);
        }

        protected override void OnPopupShow(CefBrowser browser, bool show)
        {
            base.OnPopupShow(browser, show);
        }

        protected override void OnPopupSize(CefBrowser browser, CefRect rect)
        {
            base.OnPopupSize(browser, rect);
        }

        protected override bool OnPreKeyEvent(CefBrowser browser, CefKeyEvent @event, CefEventHandle osEvent, ref int isKeyboardShortcut)
        {
            return base.OnPreKeyEvent(browser, @event, osEvent, ref isKeyboardShortcut);
        }

        protected override bool OnPrintDialog(CefBrowser browser, bool hasSelection, CefPrintDialogCallback callback)
        {
            return base.OnPrintDialog(browser, hasSelection, callback);
        }

        protected override bool OnPrintJob(CefBrowser browser, string documentName, string pdfFilePath, CefPrintJobCallback callback)
        {
            return base.OnPrintJob(browser, documentName, pdfFilePath, callback);
        }

        protected override void OnPrintReset(CefBrowser browser)
        {
            base.OnPrintReset(browser);
        }

        protected override void OnPrintSettings(CefBrowser browser, CefPrintSettings settings, bool getDefaults)
        {
            base.OnPrintSettings(browser, settings, getDefaults);
        }

        protected override void OnPrintStart(CefBrowser browser)
        {
            base.OnPrintStart(browser);
        }

        protected override bool OnProcessMessageReceived(CefBrowser browser, CefFrame frame, CefProcessId sourceProcess, CefProcessMessage message)
        {
            return base.OnProcessMessageReceived(browser, frame, sourceProcess, message);
        }

        protected override void OnProtocolExecution(CefBrowser browser, CefFrame frame, CefRequest request, ref int allowOsExecution)
        {
            base.OnProtocolExecution(browser, frame, request, ref allowOsExecution);
        }

        protected override bool OnQuotaRequest(CefBrowser browser, string originUrl, long newSize, CefCallback callback)
        {
            return base.OnQuotaRequest(browser, originUrl, newSize, callback);
        }

        protected override void OnRenderProcessTerminated(CefBrowser browser, CefTerminationStatus status)
        {
            base.OnRenderProcessTerminated(browser, status);
        }

        protected override void OnRenderViewReady(CefBrowser browser)
        {
            base.OnRenderViewReady(browser);
        }

        protected override void OnResetDialogState(CefBrowser browser)
        {
            base.OnResetDialogState(browser);
        }

        protected override void OnResourceLoadComplete(CefBrowser browser, CefFrame frame, CefRequest request, CefResponse response, CefUrlRequestStatus status, long receivedContentLength)
        {
            base.OnResourceLoadComplete(browser, frame, request, response, status, receivedContentLength);
        }

        protected override void OnResourceRedirect(CefBrowser browser, CefFrame frame, CefRequest request, CefResponse response, ref string newUrl)
        {
            base.OnResourceRedirect(browser, frame, request, response, ref newUrl);
        }

        protected override bool OnResourceResponse(CefBrowser browser, CefFrame frame, CefRequest request, CefResponse response)
        {
            return base.OnResourceResponse(browser, frame, request, response);
        }

        protected override void OnScrollOffsetChanged(CefBrowser browser, double x, double y)
        {
            base.OnScrollOffsetChanged(browser, x, y);
        }

        protected override bool OnSelectClientCertificate(CefBrowser browser, bool isProxy, string host, int port, CefX509Certificate[] certificates, CefSelectClientCertificateCallback callback)
        {
            return base.OnSelectClientCertificate(browser, isProxy, host, port, certificates, callback);
        }

        protected override bool OnSetFocus(CefBrowser browser, CefFocusSource source)
        {
            return base.OnSetFocus(browser, source);
        }

        protected override void OnStatusMessage(CefBrowser browser, string message)
        {
            base.OnStatusMessage(browser, message);
        }

        protected override void OnTakeFocus(CefBrowser browser, bool next)
        {
            base.OnTakeFocus(browser, next);
        }

        protected override void OnTextSelectionChanged(CefBrowser browser, string selectedText, CefRange selectedRange)
        {
            base.OnTextSelectionChanged(browser, selectedText, selectedRange);
        }

        protected override void OnTitleChange(CefBrowser browser, string title)
        {
            base.OnTitleChange(browser, title);
        }

        protected override bool OnTooltip(CefBrowser browser, ref string text)
        {
            return base.OnTooltip(browser, ref text);
        }

        protected override void OnVirtualKeyboardRequested(CefBrowser browser, CefTextInputMode inputMode)
        {
            base.OnVirtualKeyboardRequested(browser, inputMode);
        }

        protected override bool RunContextMenu(CefBrowser browser, CefFrame frame, CefContextMenuParams menuParams, CefMenuModel model, CefRunContextMenuCallback callback)
        {
            return base.RunContextMenu(browser, frame, menuParams, model, callback);
        }

        protected override bool StartDragging(CefBrowser browser, CefDragData dragData, CefDragOperationsMask allowedOps, int x, int y)
        {
            return base.StartDragging(browser, dragData, allowedOps, x, y);
        }

        protected override void UpdateDragCursor(CefBrowser browser, CefDragOperationsMask operation)
        {
            base.UpdateDragCursor(browser, operation);
        }
    }
}