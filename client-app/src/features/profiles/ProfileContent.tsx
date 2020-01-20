import React from "react";
import { Tab } from "semantic-ui-react";
import ProfilePhotos from "./ProfilePhotos";
import ProfileDescription from "./ProfileDescription";
import ProfileFollowings from "./ProfileFollowings";

const panes = [
  { menuItem: "About", render: () => <Tab.Pane><ProfileDescription /></Tab.Pane> },
  { menuItem: "Photos", render: () => <Tab.Pane><ProfilePhotos /></Tab.Pane> },
  {
    menuItem: "Activities",
    render: () => <Tab.Pane>Activities content</Tab.Pane>
  },
  {
    menuItem: "Followers",
    render: () => <Tab.Pane><ProfileFollowings /></Tab.Pane>
  },
  {
    menuItem: "Following",
    render: () => <Tab.Pane><ProfileFollowings /></Tab.Pane>
  }
];
const ProfileContent = () => {
  return (
    <Tab
      menu={{ fluid: true, vertical: true }}
      menuPosition="right"
      panes={panes}
    />
  );
};

export default ProfileContent;
