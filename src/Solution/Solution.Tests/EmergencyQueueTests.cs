using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution.EmergencyQueue;
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace Solution.EmergencyQueue.Tests;

[TestClass]
public class EmergencyQueueTests
{
    [TestMethod]
    public void TambahPanggilan_AddsPanggilanToQueue_QueueContainsPanggilan()
    {
        // Arrange
        var callCenter = new EmergencyCallCenter();
        var panggilan = new PanggilanDarurat("EMG001", "Kebakaran di gedung");

        // Act
        callCenter.TambahPanggilan(panggilan);

        // Assert
        Assert.AreEqual(1, callCenter.QueueCount(), "Queue should contain one panggilan.");
    }

    [TestMethod]
    public void TanganiPanggilan_RemovesPanggilanFromQueue_QueueIsEmpty()
    {
        // Arrange
        var callCenter = new EmergencyCallCenter();
        var panggilan = new PanggilanDarurat("EMG001", "Kebakaran di gedung");
        callCenter.TambahPanggilan(panggilan);

        // Act
        callCenter.TanganiPanggilan();

        // Assert
        Assert.AreEqual(0, callCenter.QueueCount(), "Queue should be empty after handling the panggilan.");
    }

    [TestMethod]
    public void LihatAntrianPanggilan_ReturnsCorrectAntrianDetails()
    {
        // Arrange
        var callCenter = new EmergencyCallCenter();
        var panggilan1 = new PanggilanDarurat("EMG001", "Kebakaran di gedung");
        var panggilan2 = new PanggilanDarurat("EMG002", "Kecelakaan di jalan tol");
        callCenter.TambahPanggilan(panggilan1);
        callCenter.TambahPanggilan(panggilan2);
        using var sw = new StringWriter();
        Console.SetOut(sw);

        // Act
        callCenter.LihatAntrianPanggilan();
        var result = sw.ToString().Trim();

        // Assert
        StringAssert.Contains(result, "EMG001");
        StringAssert.Contains(result, "EMG002");
    }
}
