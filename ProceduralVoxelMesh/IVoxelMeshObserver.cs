﻿// Copyright 2015 afuzzyllama. All Rights Reserved.

namespace ProceduralVoxelMesh
{
    /// <summary>
    /// Allows an object to observe events from a voxel mesh
    /// </summary>
    public interface IVoxelMeshObserver
    {
        /// <summary>
        /// Notifies object that voxel mesh has been updated
        /// </summary>
        void Notify();
    }
}