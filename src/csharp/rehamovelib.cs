namespace UnityRehamove {
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class rehamovelib {
  public static RehamoveDevice open_port(string port_name) {
    global::System.IntPtr cPtr = rehamovelibPINVOKE.open_port(port_name);
    RehamoveDevice ret = (cPtr == global::System.IntPtr.Zero) ? null : new RehamoveDevice(cPtr, false);
    return ret;
  }

  public static int close_port(RehamoveDevice r) {
    int ret = rehamovelibPINVOKE.close_port(RehamoveDevice.getCPtr(r));
    return ret;
  }

  public static int initialize_low_level(RehamoveDevice r) {
    int ret = rehamovelibPINVOKE.initialize_low_level(RehamoveDevice.getCPtr(r));
    return ret;
  }

  public static int stop_low_level(RehamoveDevice r) {
    int ret = rehamovelibPINVOKE.stop_low_level(RehamoveDevice.getCPtr(r));
    return ret;
  }

  public static int pulse(RehamoveDevice r, int channel, float current, int pulse_width) {
    int ret = rehamovelibPINVOKE.pulse(RehamoveDevice.getCPtr(r), channel, current, pulse_width);
    return ret;
  }

  public static int custom_pulse(RehamoveDevice r, int channel, int num_points, float c0, int w0, float c1, int w1, float c2, int w2, float c3, int w3, float c4, int w4, float c5, int w5, float c6, int w6, float c7, int w7, float c8, int w8, float c9, int w9, float c10, int w10, float c11, int w11, float c12, int w12, float c13, int w13, float c14, int w14, float c15, int w15) {
    int ret = rehamovelibPINVOKE.custom_pulse(RehamoveDevice.getCPtr(r), channel, num_points, c0, w0, c1, w1, c2, w2, c3, w3, c4, w4, c5, w5, c6, w6, c7, w7, c8, w8, c9, w9, c10, w10, c11, w11, c12, w12, c13, w13, c14, w14, c15, w15);
    return ret;
  }

  public static int change_mode(RehamoveDevice r, int mode) {
    int ret = rehamovelibPINVOKE.change_mode(RehamoveDevice.getCPtr(r), mode);
    return ret;
  }

  public static int set_pulse_data(RehamoveDevice r, float current, int pulse_width) {
    int ret = rehamovelibPINVOKE.set_pulse_data(RehamoveDevice.getCPtr(r), current, pulse_width);
    return ret;
  }

  public static int run(RehamoveDevice r, int channel, float period, int total_milliseconds) {
    int ret = rehamovelibPINVOKE.run(RehamoveDevice.getCPtr(r), channel, period, total_milliseconds);
    return ret;
  }

  public static int midlevel_start(RehamoveDevice r, int channel, float period) {
    int ret = rehamovelibPINVOKE.midlevel_start(RehamoveDevice.getCPtr(r), channel, period);
    return ret;
  }

  public static int midlevel_update(RehamoveDevice r) {
    int ret = rehamovelibPINVOKE.midlevel_update(RehamoveDevice.getCPtr(r));
    return ret;
  }

  public static int midlevel_end(RehamoveDevice r) {
    int ret = rehamovelibPINVOKE.midlevel_end(RehamoveDevice.getCPtr(r));
    return ret;
  }

  public static string get_version() {
    string ret = rehamovelibPINVOKE.get_version();
    return ret;
  }

  public static int get_battery(RehamoveDevice r) {
    int ret = rehamovelibPINVOKE.get_battery(RehamoveDevice.getCPtr(r));
    return ret;
  }

  public static int get_mode(RehamoveDevice r) {
    int ret = rehamovelibPINVOKE.get_mode(RehamoveDevice.getCPtr(r));
    return ret;
  }

  public static float get_current(RehamoveDevice r) {
    float ret = rehamovelibPINVOKE.get_current(RehamoveDevice.getCPtr(r));
    return ret;
  }

  public static int get_pulse_width(RehamoveDevice r) {
    int ret = rehamovelibPINVOKE.get_pulse_width(RehamoveDevice.getCPtr(r));
    return ret;
  }

  public static int battery_request(RehamoveDevice r) {
    int ret = rehamovelibPINVOKE.battery_request(RehamoveDevice.getCPtr(r));
    return ret;
  }

}
}
