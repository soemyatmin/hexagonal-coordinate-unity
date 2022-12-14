using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class ExtensionsHandy{
    // The wrapper class name is actually irrelevant - it is not used at all.
    // Choose any convenient name for the wrapper class.
    public static bool HasComponent<T>(this GameObject obj) where T : Component {
        return obj.GetComponent<T>() != null;
    }
    public static bool HasComponent<T>(this Transform obj) where T : Component {
        return obj.GetComponent<T>() != null;
    }

    public static bool IsNear(this float ff, float target) {
        float difference = ff - target;
        difference = Mathf.Abs(difference);
        if (difference < 20f)
            return true;
        else
            return false;
    }

    public static float Jiggle(this float ff) {
        return ff * UnityEngine.Random.Range(0.9f, 1.1f);
    }

    public static Color Colored(this float alpha, int r, int g, int b) {
        return new Color(
            (float)r / 255f,
            (float)g / 255f,
            (float)b / 255f,
            alpha);
    }

    public static void Merge<TKey, TValue>(this Dictionary<TKey, TValue> me, Dictionary<TKey, TValue> merge) {
        foreach (var item in merge) {
            me[item.Key] = item.Value;
        }
    }
}