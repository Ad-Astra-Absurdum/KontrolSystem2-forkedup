﻿using KontrolSystem.KSP.Runtime.KSPVessel;
using KontrolSystem.TO2.Binding;
using KSP.Sim;
using KSP.Sim.impl;

namespace KontrolSystem.KSP.Runtime.KSPOrbit {
    public class BodyWrapper : KSPOrbitModule.IBody, KSPVesselModule.IKSPTargetable {
        private readonly CelestialBodyComponent body;

        public BodyWrapper(CelestialBodyComponent body) => this.body = body;
        
        public string Name => body.Name;

        public double GravParameter => body.gravParameter;
        
        public double SoiRadius => body.sphereOfInfluence;

        public double RotationPeriod => body.rotationPeriod;
        
        [KSField] public KSPOrbitModule.IOrbit Orbit => new OrbitWrapper(body.Orbit);

        public bool HasAtmosphere => body.hasAtmosphere;

        public double AtmosphereDepth => body.atmosphereDepth;

        public double Radius => body.radius;
        
        public KSPOrbitModule.IOrbit CreateOrbit(Vector3d position, Vector3d velocity, double ut) {
            PatchedConicsOrbit orbit = new PatchedConicsOrbit(body.universeModel);
            
            orbit.UpdateFromStateVectors(new Position(body.coordinateSystem, position), new Velocity(body.bodyMotionFrame, velocity), body, ut);

            return new OrbitWrapper(orbit);
        }

    }
}
