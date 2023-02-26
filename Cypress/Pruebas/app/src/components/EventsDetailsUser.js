import React, {Component} from 'react'
import HeaderUser from './HeaderUser'
import axios from 'axios'
import Button from "@mui/material/Button";
import ArrowBackIosIcon from '@mui/icons-material/ArrowBackIos';
import DeleteIcon from '@mui/icons-material/Delete';
import EditIcon from '@mui/icons-material/Edit';
import Cookies from 'universal-cookie'

const cookies = new Cookies();

    class EventsDetailsUser extends Component{
        constructor(props){
            super(props);
            this.state={
             details:''
            }
        }
  
        componentDidMount(){
            
            //Sesiones
            if (typeof cookies.get('username') === 'undefined' ) {
                window.location.href = "./"
            }
    
            if (cookies.get('ownerType') === "admin") {
                window.location.href = "./OwnerController"
            }
        }

        getEvent(){
            let eventId = this.props.match.params.id;
            axios.get(`http://localhost:3000/events/${eventId}`)
            .then(response => {
                this.setState({details: response.data},() => {
                    console.log(this.state);

                })
            })

        }


        render(){
            return(
                <div className="container">
                <div className="row justify-content-center"></div>
                <HeaderUser/> <br/><br/>
                <Button href="/EventsUserRest" className="btn-back" variant='contained' color='success' startIcon={<ArrowBackIosIcon />}>BACK</Button><br/><br/>
                <h1>{this.state.details.name}</h1>
                <ul className='list-group'>
                    <li className='list-group-item'>Description: {this.state.details.description}</li>
                    <li className='list-group-item'>Date: {this.state.details.date}</li>
                    <li className='list-group-item'>Hour: {this.state.details.hour}</li><br/>
                    
                </ul>
                
                
                </div>
            )
        }

    }
    export default EventsDetailsUser;