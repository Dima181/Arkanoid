using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContoller : MonoBehaviour
{
    [SerializeField][NotNull] private GameObject DeathPanel;
    [SerializeField][NotNull] private GameObject EndPanel;

    [SerializeField][NotNull] private List<Block> BlockObjects;
    [SerializeField][NotNull] private Ball BallObject;


    void Start()
    {
        BallObject.BallDestroyed.AddListener(OnBallDestroyed);
        foreach (var block in BlockObjects)
            block.BlockDestroyed.AddListener(OnBlockDestroyed);

        CheckGameFinished();
    }

    private void OnBallDestroyed(Ball ball)
    {
        DeathPanel.SetActive(true);
    }
    private void OnBlockDestroyed(Block block)
    {
        BlockObjects.Remove(block);
        CheckGameFinished();
    }
    private void CheckGameFinished()
    {
        if (BlockObjects.Count == 0)
        {
            Destroy(BallObject.gameObject);
            EndPanel.SetActive(true);
        }
    }
}
