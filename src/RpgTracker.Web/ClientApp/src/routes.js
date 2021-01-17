
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
    component: DashboardPage,
    layout: "/admin"
  },
  {
    path: "/monsters",
    name: "Monsters",
    icon: Notifications,
    component: DashboardPage,
    layout: "/admin"
  },
  {
    path: "/maps",
    name: "Maps",
    icon: Notifications,
    component: DashboardPage,
    layout: "/admin"
  },
];

export default dashboardRoutes;
