using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Androidx.Navigation
{

    // Metadata.xml XPath class reference: path="/api/package[@name='androidx.navigation']/class[@name='NavGraphNavigator']"
    [global::Android.Runtime.Register("androidx/navigation/NavGraphNavigator", DoNotGenerateAcw = true)]
    public partial class NavGraphNavigator : global::Androidx.Navigation.Navigator
    {
        static Delegate cb_createDestination;
#pragma warning disable 0169
        static Delegate GetCreateDestinationHandler()
        {
            if (cb_createDestination == null)
                cb_createDestination = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_CreateDestination);
            return cb_createDestination;
        }

        static IntPtr n_CreateDestination(IntPtr jnienv, IntPtr native__this)
        {
            global::Androidx.Navigation.NavGraphNavigator __this = global::Java.Lang.Object.GetObject<global::Androidx.Navigation.NavGraphNavigator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.CreateDestination());
        }
#pragma warning restore 0169

        static IntPtr id_createDestination;
        // Metadata.xml XPath method reference: path="/api/package[@name='androidx.navigation']/class[@name='NavGraphNavigator']/method[@name='createDestination' and count(parameter)=0]"
        [Register("createDestination", "()Landroidx/navigation/NavGraph;", "GetCreateDestinationHandler")]
        public override unsafe global::Androidx.Navigation.NavGraph CreateDestination()
        {
            if (id_createDestination == IntPtr.Zero)
                id_createDestination = JNIEnv.GetMethodID(class_ref, "createDestination", "()Landroidx/navigation/NavGraph;");
            try
            {

                if (((object)this).GetType() == ThresholdType)
                    return global::Java.Lang.Object.GetObject<global::Androidx.Navigation.NavGraph>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_createDestination), JniHandleOwnership.TransferLocalRef);
                else
                    return global::Java.Lang.Object.GetObject<global::Androidx.Navigation.NavGraph>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "createDestination", "()Landroidx/navigation/NavGraph;")), JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }
}