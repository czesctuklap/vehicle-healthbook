# Vehicle HealthBook

Vehicle HealthBook is a desktop application designed for monitoring vehicle statistics and managing a fleet of vehicles. It features a simple interface built in C# and uses a SQL database for reliable data storage.

### Features
- **Adding New Vehicles**: Users can add new vehicles to the database, assigning basic information and statistics such as mileage and insurance periods.
- **Editing Existing Vehicles**: Users can edit existing vehicle data excluding name and surname onf the owner.
- **Deleting Vehicles**: Vehicles can be deleted either from the main view or the edit menu.
- **Monitoring Vehicle Condition**: An intuitive graphical interface allows users to monitor the condition of vehicles, quickly browse data, and update it as needed.
- **Tracking Key Indicators**: Users can track key indicators of vehicles, enabling timely responses to potential issues or the need for maintenance.

### Database Installation Instruction
Before running the application it is necessary to download the `vehicle_hb.sql` file, which contains the database structure.
In SQL console type:
- `create database vehicle_halthbook`
- `use vehicle_halthbook`
- `/. ` and copy the location of the `vehicle_hb.sql` file replacing every `\` with `/`


The project is implemented using the `Model-View-Presenter` architecture. 
