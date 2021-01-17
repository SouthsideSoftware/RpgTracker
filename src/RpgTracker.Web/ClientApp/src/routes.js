
// @material-ui/icons
import Dashboard from "@material-ui/icons/Dashboard";
import Person from "@material-ui/icons/Person";
import LibraryBooks from "@material-ui/icons/LibraryBooks";
import BubbleChart from "@material-ui/icons/BubbleChart";
import LocationOn from "@material-ui/icons/LocationOn";
import Notifications from "@material-ui/icons/Notifications";
import Unarchive from "@material-ui/icons/Unarchive";
import Language from "@material-ui/icons/Language";

// core components/views for Admin layout
import DashboardPage from "views/Dashboard/Dashboard.js";
import EncountersPage from "views/Encounters/Encounters.js";
import CharactersPage from "views/Characters/Characters.js";
import MonstersPage from "views/Monsters/Monsters.js";
import BattleMapsPage from "views/BattleMaps/BattleMaps.js";

const dashboardRoutes = [
  {
    path: "/dashboard",
    name: "Dashboard",
    icon: Dashboard,
    component: DashboardPage,
    layout: "/admin"
  },
  {
    path: "/encounters",
    name: "Encounters",
    icon: Notifications,
    component: EncountersPage,
    layout: "/admin"
  },
  {
    path: "/characters",
    name: "Characters",
    icon: Notifications,
    component: CharactersPage,
    layout: "/admin"
  },
  {
    path: "/monsters",
    name: "Monsters",
    icon: Notifications,
    component: MonstersPage,
    layout: "/admin"
  },
  {
    path: "/battlemaps",
    name: "Battle maps",
    icon: Notifications,
    component: BattleMapsPage,
    layout: "/admin"
  },
];

export default dashboardRoutes;
