import React from "react";
import { Tab } from "semantic-ui-react";
import ProfilePhotos from "./ProfilePhotos";
import ProfileDescription from "./ProfileDescription";
import ProfileFollowings from "./ProfileFollowings";
import ProfileActivities from "./ProfileActivities";

const panes = [
  {
    menuItem: "About",
    render: () => (
      <Tab.Pane>
        <ProfileDescription />
      </Tab.Pane>
    )
  },
  {
    menuItem: "Photos",
    render: () => (
      <Tab.Pane>
        <ProfilePhotos />
      </Tab.Pane>
    )
  },
  {
    menuItem: "Activities",
    render: () => (
      <Tab.Pane>
        <ProfileActivities />
      </Tab.Pane>
    )
  },
  {
    menuItem: "Followers",
    render: () => (
      <Tab.Pane>
        <ProfileFollowings />
      </Tab.Pane>
    )
  },
  {
    menuItem: "Following",
    render: () => (
      <Tab.Pane>
        <ProfileFollowings />
      </Tab.Pane>
    )
  }
];

interface IProps {
  setActiveTab: (activeIndex: any) => void;
}

const ProfileContent: React.FC<IProps> = ({ setActiveTab }) => {
  return (
    <Tab
      menu={{ fluid: true, vertical: true }}
      menuPosition="right"
      panes={panes}
      onTabChange={(e, data) => setActiveTab(data.activeIndex)}
    />
  );
};

export default ProfileContent;
