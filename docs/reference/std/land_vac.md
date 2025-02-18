# std::land::vac



## Functions


### vac_break_zero

```rust
pub fn vac_break_zero ( vessel : ksp::vessel::Vessel ) -> Unit
```



### vac_deceleration_burn

```rust
pub fn vac_deceleration_burn ( vessel : ksp::vessel::Vessel,
                               simulation : std::land::landing_simulation::ReentrySimulation,
                               initial_result : (brake_time : float, end_latitude : float, end_longitude : float, end_time : float, path : ksp::math::GlobalPosition[]),
                               landing_site : ksp::orbit::GeoCoordinates,
                               speed_policy : sync fn(ksp::math::Vec3, ksp::math::Vec3) -> float ) -> Result<Unit, string>
```



### vac_land

```rust
pub fn vac_land ( vessel : ksp::vessel::Vessel,
                  landing_side : ksp::orbit::GeoCoordinates,
                  land_stage : int ) -> Result<Unit, string>
```



### vac_land_course_correct

```rust
pub fn vac_land_course_correct ( vessel : ksp::vessel::Vessel,
                                 simulation : std::land::landing_simulation::ReentrySimulation,
                                 initial_result : (brake_time : float, end_latitude : float, end_longitude : float, end_time : float, path : ksp::math::GlobalPosition[]),
                                 landing_site : ksp::orbit::GeoCoordinates ) -> Result<(brake_time : float, end_latitude : float, end_longitude : float, end_time : float, path : ksp::math::GlobalPosition[]), string>
```



### vac_land_prepare_deorbit

```rust
pub fn vac_land_prepare_deorbit ( vessel : ksp::vessel::Vessel,
                                  landing_site : ksp::orbit::GeoCoordinates ) -> Result<Unit, string>
```



### vac_touchdown

```rust
pub fn vac_touchdown ( vessel : ksp::vessel::Vessel ) -> Unit
```


