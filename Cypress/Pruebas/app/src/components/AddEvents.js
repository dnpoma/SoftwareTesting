import React,{Component} from 'react'
import HeaderAdmin from './HeaderAdmin'
import axios from 'axios'
import Button from "@mui/material/Button";
import ArrowBackIosIcon from '@mui/icons-material/ArrowBackIos';
import TextField from '@mui/material/TextField';
import { DatePicker, TimePicker } from "@material-ui/pickers";
import SendIcon from '@mui/icons-material/Send';
import { useNavigate } from 'react-router'
import { CloudSyncTwoTone } from '@mui/icons-material';
import DesktopTimePicker from './Time'
import DesktopDatePicker from './Date'



    export default class AddEvents extends Component {

        state = {
            events:[],
            id:'',
            name:'',
            description:'',
            date:'',
            hour:''
        }

        onSubmit =  e => {
            axios.post('http://localhost:3000/events',{
            id: this.state.eventId,
            name: this.state.eventName,
            description: this.state.eventDes,
            date: this.state.eventDate,
            hour: this.state.eventHour
            })
            e.preventDefault();
            this.setState({eventId:''});
            this.setState({eventName:''});
            this.setState({eventDes:''});
            this.setState({eventDate:''});
            this.setState({eventHour:''});

        }
    
        onChangeEventId = (e) => {
           this.setState({
               eventId:e.target.value
           })

        }
        onChangeEventName = (e) => {
            this.setState({
                eventName:e.target.value
            })
 
         }
         onChangeEventDes = (e) => {
            this.setState({
                eventDes:e.target.value
            })
 
         }
         onChangeEventDate = (e) => {
            this.setState({
                eventDate:e.target.value
            })
 
         }
         onChangeEventHour = (e) => {
            this.setState({
                eventHour:e.target.value
            })
 
         }



            render(){

            return(
                <div className="">
                <HeaderAdmin/> <br/><br/>
                <div className="container">
                <Button href="/EventsAdminRest" className="btn-back" variant='contained' color='success' startIcon={<ArrowBackIosIcon />}>BACK</Button><br/><br/>
                <div className="row align-self-center ">
                <center><h1 className=''>Add Events</h1></center>
                <center><form onSubmit={this.onSubmit} className=" form-group tm-bg-white-transparent border border-success rounded col-sm-6"  >
                    <div className='col-sm-12'>
                    <div className='input-field p-3 col-5'>
                        <TextField 
                        id="standard-basic" 
                        label="Event Id:" 
                        variant="outlined" 
                        value={this.state.eventId}
                        onChange={this.onChangeEventId}/>
                        </div>
                    <div className='input-field p-2 col-5'>
                    <TextField id="standard-basic" label="Event Name:" variant="outlined" name='name' value={this.state.eventName}  onChange={this.onChangeEventName}/></div>
                    <div className='input-field p-2 col-5'>
                    <TextField id="standard-basic" label="Description:" variant="outlined" name='description' value={this.state.eventDes} onChange={this.onChangeEventDes}/></div>
                    </div>
                    <div className='input-field p-3 col-5'>
                    <TextField id="standard-basic" variant="outlined" label="Event Date:" placeholder="Ex:12/12/2021" value={this.state.eventDate}  onChange={this.onChangeEventDate}  />
                    </div>
                    <div className='input-field p-3 col-5'>
                    <TextField id="standard-basic" variant="outlined" label="Event Hour:"  placeholder="Ex:19:00" value={this.state.eventHour}  onChange={this.onChangeEventHour} />
                        </div>
                        <div className='input-field p-2'>
                        <Button type="submit" variant="contained" color='success' endIcon={<SendIcon />}>
                        Send
                        </Button>
                        </div>
                </form></center>
                </div></div><br/><br/>
            </div>

            )
        }    
    }
 