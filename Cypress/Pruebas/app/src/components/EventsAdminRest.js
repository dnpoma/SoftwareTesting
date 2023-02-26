import React, {useEffect, useState, Component} from 'react';
import HeaderAdmin from './HeaderAdmin'
import axios from 'axios'
import EventsItem  from './EventsItem'
import AddIcon from '@mui/icons-material/Add';
import Button from "@mui/material/Button";
import { green } from '@mui/material/colors';
import Cookies from 'universal-cookie'


const cookies = new Cookies();

    class EventsAdminRest extends Component{
        
        constructor(){
            super();
            this.state={
             events:[],
             id:''
            }
        }
        
        componentDidMount(){
            this.getEvents();
            
             /*Sesiones*/
            if (typeof cookies.get('username') === 'undefined' ) {
                window.location.href = "./"
            }

            if (cookies.get('ownerType') === "owner") {
                window.location.href = "./account"
            }
        }


        getEvents(){
            axios.get('http://localhost:3000/events')
            .then(response => {
                this.setState({events: response.data},() => {

                    //console.log(this.state);

                })
            })
            .catch(err => console.log(err));
        }

        onChangeEventId = (e) => {
            this.setState({
                id:e.target.value
            })
 
         }

        onSubmit = e => {
            axios.delete('http://localhost:3000/events/'+this.state.id)
         

        }
    


        render(){

            const eventItems = this.state.events.map((event) => {

                return(
                    <EventsItem key={event.id} item={event}/>
                )
            })

            return (
                <div className="">
                    
                    <HeaderAdmin/> <br></br>
                    <div className="container item">
                        <div className="col-sm-12 p-4 text-center">
                            <h2 className="p-2 ">Events Created</h2>
                            <Button variant="contained" className="btn-back " href="/AddEvents" color='success'startIcon={<AddIcon />}
                                sx = {{bgcolor: green[500]}}
                            >Add Event</Button>
                        </div>

                        <div className="row justify-content-md-center ">{eventItems}</div><br/>
                    
                    </div>
                </div>
            )
        }   
        
    }

    export default EventsAdminRest;