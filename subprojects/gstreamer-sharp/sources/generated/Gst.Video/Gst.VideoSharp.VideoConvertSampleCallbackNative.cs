// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.VideoSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void VideoConvertSampleCallbackNative(IntPtr sample, IntPtr error, IntPtr user_data);

	internal class VideoConvertSampleCallbackInvoker {

		VideoConvertSampleCallbackNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~VideoConvertSampleCallbackInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal VideoConvertSampleCallbackInvoker (VideoConvertSampleCallbackNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal VideoConvertSampleCallbackInvoker (VideoConvertSampleCallbackNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal VideoConvertSampleCallbackInvoker (VideoConvertSampleCallbackNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.Video.VideoConvertSampleCallback Handler {
			get {
				return new Gst.Video.VideoConvertSampleCallback(InvokeNative);
			}
		}

		void InvokeNative (Gst.Sample sample, IntPtr error)
		{
			native_cb (sample == null ? IntPtr.Zero : sample.Handle, error, __data);
		}
	}

	internal class VideoConvertSampleCallbackWrapper {

		public void NativeCallback (IntPtr sample, IntPtr error, IntPtr user_data)
		{
			try {
				managed (sample == IntPtr.Zero ? null : (Gst.Sample) GLib.Opaque.GetOpaque (sample, typeof (Gst.Sample), false), error);
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal VideoConvertSampleCallbackNative NativeDelegate;
		Gst.Video.VideoConvertSampleCallback managed;

		public VideoConvertSampleCallbackWrapper (Gst.Video.VideoConvertSampleCallback managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new VideoConvertSampleCallbackNative (NativeCallback);
		}

		public static Gst.Video.VideoConvertSampleCallback GetManagedDelegate (VideoConvertSampleCallbackNative native)
		{
			if (native == null)
				return null;
			VideoConvertSampleCallbackWrapper wrapper = (VideoConvertSampleCallbackWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}