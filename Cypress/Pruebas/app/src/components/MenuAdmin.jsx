import * as React from 'react';
import Box from '@mui/material/Box';
import Avatar from '@mui/material/Avatar';
import Menu from '@mui/material/Menu';
import MenuItem from '@mui/material/MenuItem';
import ListItemIcon from '@mui/material/ListItemIcon';
import Divider from '@mui/material/Divider';
import IconButton from '@mui/material/IconButton';
import Tooltip from '@mui/material/Tooltip';
import PersonAdd from '@mui/icons-material/PersonAdd';
import Settings from '@mui/icons-material/Settings';
import Logout from '@mui/icons-material/Logout';
import Button from "@mui/material/Button";
import { Link } from "react-router-dom";
import { useNavigate } from 'react-router'
import Cookies from 'universal-cookie'
import LocalAtmOutlinedIcon from '@mui/icons-material/LocalAtmOutlined';
import EventIcon from '@mui/icons-material/Event';
import SupervisedUserCircleIcon from '@mui/icons-material/SupervisedUserCircle';


const cookies = new Cookies();

export default function AccountMenu() {
  const [anchorEl, setAnchorEl] = React.useState(null);
  const open = Boolean(anchorEl);
  const navigate = useNavigate()

  const cerrarSesion = () =>{
    cookies.remove('id', {path: "/"})
    cookies.remove('cardIdentification', {path: "/"})
    cookies.remove('name', {path: "/"})
    cookies.remove('lastName', {path: "/"})
    cookies.remove('username', {path: "/"})
    cookies.remove('email', {path: "/"})
    cookies.remove('telephone',  {path: "/"})
    console.log(cookies.get('id'))
    navigate({
      pathname: '/'
    })
  }

  const handleClick = (event) => {
    setAnchorEl(event.currentTarget);
  };
  const handleClose = () => {
    setAnchorEl(null);
  };
  return (
    <React.Fragment>
      <Box sx={{ display: 'flex', alignItems: 'center', textAlign: 'center' }}>
      <div className='col-sm-5'><Button href="/OwnerController" className='buttonMenu' startIcon={<SupervisedUserCircleIcon fontSize="medium" />}>OWNERS</Button></div>  
      <div className='col-sm-5'><Button href="/PaymentControllerAdmin" className='buttonMenu' startIcon={<LocalAtmOutlinedIcon fontSize="medium" />} >PAYMENTS</Button></div>
      <div className='col-sm-5'><Button href="/EventsAdminRest" className='buttonMenu' startIcon={<EventIcon fontSize="medium" />} >EVENTS</Button></div>
        <Tooltip title="Log Out">
          <IconButton
            onClick={handleClick}
            size="small"
            sx={{ ml: 2 }}
            aria-controls={open ? 'account-menu' : undefined}
            aria-haspopup="true"
            aria-expanded={open ? 'true' : undefined}
          >
            <Avatar sx={{ width: 32, height: 32, background: '#1C1A1A'}}>A</Avatar>
          </IconButton>
        </Tooltip>
      </Box>
      <Menu
        anchorEl={anchorEl}
        id="account-menu"
        open={open}
        onClose={handleClose}
        onClick={handleClose}
        PaperProps={{
          elevation: 0,
          sx: {
            overflow: 'visible',
            filter: 'drop-shadow(0px 2px 8px rgba(0,0,0,0.32))',
            mt: 1.5,
            '& .MuiAvatar-root': {
              width: 32,
              height: 32,
              ml: -0.5,
              mr: 1,
            },
            '&:before': {
              content: '""',
              display: 'block',
              position: 'absolute',
              top: 0,
              right: 14,
              width: 10,
              height: 10,
              bgcolor: 'background.paper',
              transform: 'translateY(-50%) rotate(45deg)',
              zIndex: 0,
            },
          },
        }}
        transformOrigin={{ horizontal: 'right', vertical: 'top' }}
        anchorOrigin={{ horizontal: 'right', vertical: 'bottom' }}
      >
        <Divider />
        <MenuItem onClick= { cerrarSesion }>
          <ListItemIcon>
            <Logout fontSize="small" />
          </ListItemIcon>
          Logout
        </MenuItem>
      </Menu>
    </React.Fragment>
  );
}