using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlant
{
    GameObject SeedGameObject { get; set; }
    GameObject SproutGameObject { get; set; }
    GameObject TreeGameObject { get; set; }
    int WaterLevel { get; set; }
    int WaterLevelMax { get; set; }
    int SproutWaterLevel { get; set; }
    int TreeWaterLevel { get; set; }
    void CheckPlantState();
    void CheckGrow();
    void AttributeGameObjects();
    void SetInitialPlantState();
    void AddTotalPlants();

}
