using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MapEditor : EditorWindow
{
    int chang = 0;
    int kuan = 0;
    public static GameObject game;
    [MenuItem("地形/绘制地图")]
    public static void OpenMap()
    {
       
        if (EditorApplication.isPlaying)
        {
            game = GameObject.Find("OBJ");
            MapEditor win = GetWindow<MapEditor>("地形编辑");
            win.Show();
        }
      
    }
    private void OnGUI()
    {
        GUILayout.Label("行数");
        chang = EditorGUILayout.IntField(chang);
        GUILayout.Label("列数");
        kuan = EditorGUILayout.IntField(kuan);
        if (GUILayout.Button("开始编辑"))
        {
            MapEditor win = GetWindow<MapEditor>("地形编辑");
            TerrainMang map =  game.AddComponent<TerrainMang>();
            map.Init(chang, kuan);
            win.Close();
        }
    }
}
